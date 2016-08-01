using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace CustFontLoader
{
    public partial class FontLoader : Form
    {
        PrivateFontCollection mFontList = null;
        public FontLoader()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FontLoader_Load(object sender, EventArgs e)
        {
            var vFolderDialog = new FolderBrowserDialog();
            vFolderDialog.ShowDialog(this);
            lblFolderPath.Text = vFolderDialog.SelectedPath;
            var vFontsFolder = new DirectoryInfo(vFolderDialog.SelectedPath);
            var vFilesList = vFontsFolder.GetFiles();
             mFontList = new PrivateFontCollection();
            foreach (var vSelFontFile in vFilesList)
            {
                mFontList.AddFontFile(vSelFontFile.FullName);              
            }
            var vCbItemList = new ArrayList();
            foreach (var vFontFamily in mFontList.Families)
            {
                vCbItemList.Add(vFontFamily.Name);
            }
            cbFontList.DataSource = vCbItemList;
        }

        private void cbFontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vFontIndex =cbFontList.SelectedIndex;
            lbl10ptSample.Font = new Font(mFontList.Families[vFontIndex], 10);
            lbl12ptSample.Font = new Font(mFontList.Families[vFontIndex], 12);
            lbl15ptSample.Font = new Font(mFontList.Families[vFontIndex], 15);
            lbl18ptSample.Font = new Font(mFontList.Families[vFontIndex], 18);
            lbl22ptSample.Font = new Font(mFontList.Families[vFontIndex], 22);
            lbl30ptSample.Font= new Font(mFontList.Families[vFontIndex], 30);
        }
    }
}
