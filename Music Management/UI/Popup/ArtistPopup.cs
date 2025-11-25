using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Music_Management.UI.Popup
{
    public partial class ArtistPopup : Form
    {
        private readonly string option;
        private readonly Artist? editingArtist;

        public ArtistPopup(string option, Artist artist = null)
        {
            InitializeComponent();

            this.option = option;     // "add" / "edit"
            this.editingArtist = artist;

            Text = option == "add" ? "Thêm nghệ sĩ" : "Chỉnh sửa nghệ sĩ";
            lblTitle.Text = Text;

            CenterToScreen();

            if (option == "edit" && editingArtist != null)
                FillValues();
        }

        private void FillValues()
        {
            txtName.Text = editingArtist.Name;
            txtBirth.Text = editingArtist.BirthDay;
            txtCountry.Text = editingArtist.Country;
            lblImagePath.Text = editingArtist.ImagePath;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Chọn file ảnh";
            dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblImagePath.Text = dialog.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                Utils.ShowWarning("Vui lòng nhập tên nghệ sĩ!");
                return;
            }

            if (!File.Exists(lblImagePath.Text))
            {
                Utils.ShowWarning("Vui lòng chọn file ảnh hợp lệ!");
                return;
            }

            if (option == "add")
            {
                Artist artist = new Artist()
                {
                    Name = txtName.Text,
                    BirthDay = txtBirth.Text,
                    Country = txtCountry.Text,
                    ImagePath = lblImagePath.Text
                };
                ArtistService.Add(artist);
            }
            else if (option == "edit")
            {
                editingArtist.Name = txtName.Text;
                editingArtist.BirthDay = txtBirth.Text;
                editingArtist.Country = txtCountry.Text;
                editingArtist.ImagePath = lblImagePath.Text;
                ArtistService.Edit(editingArtist);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
