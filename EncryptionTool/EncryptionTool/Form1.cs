namespace EncryptionTool;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        encryptionMode.SelectedIndex=0;
    }

    private void EncryptionBTN_Click(object sender, EventArgs e)
    {
        string source = string.Empty;
        /*
         * 32��(�j) 0
         * 32��(�p) 1
         * 16��(�j) 2
         * 16��(�p) 3
         */
        switch (encryptionMode.SelectedIndex)
        {
            case 0:
                source = MD5Helper.Encrypt(textBoxMD5Souce.Text).ToUpper();
                break;
            case 1:
                source = MD5Helper.Encrypt(textBoxMD5Souce.Text);
                break;
            case 2:
                source = MD5Helper.Encrypt(textBoxMD5Souce.Text,16).ToUpper();
                break;
            case 3:
                source = MD5Helper.Encrypt(textBoxMD5Souce.Text,16);
                break;
            default:
                break;
        };
        textBoxMD5Target.Text = source;
    }
}