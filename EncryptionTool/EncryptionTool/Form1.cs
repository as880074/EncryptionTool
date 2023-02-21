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
         * 32位(大) 0
         * 32位(小) 1
         * 16位(大) 2
         * 16位(小) 3
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