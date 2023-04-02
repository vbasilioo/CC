using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Windows.Media;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;

namespace CareerConnect.Views{
    public partial class Dashboard : Form{

        //campos
        private IconButton currentAtivo;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private IconPictureBox iconCurrentChildForm;

        //estruturas das cores
        private struct RGBColors{
            public static Color color1 = Color.FromArgb(255,215,0);
            public static Color color2 = Color.FromArgb(139, 0, 0);
        }

        //construtor
        public Dashboard(){
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PainelSidebar.Controls.Add(leftBorderBtn);
            iconCurrentChildForm = new IconPictureBox();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //metodos
        private void ActiveButton(object senderBtn, Color color){
            if(senderBtn != null){
                DisableButton();
                //botao
                currentAtivo = (IconButton)senderBtn;
                currentAtivo.BackColor = Color.FromArgb(37,36,81);
                currentAtivo.ForeColor = color;
                currentAtivo.TextAlign = ContentAlignment.MiddleCenter;
                currentAtivo.IconColor = color;
                currentAtivo.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentAtivo.ImageAlign = ContentAlignment.MiddleRight;
                
                //sidebar
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentAtivo.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current form
                iconCurrentChildForm.IconChar = currentAtivo.IconChar;
                iconCurrentChildForm.IconColor = color;
                iconCurrentChildForm.Visible = true;
            }
        }

        private void DisableButton(){
            if(currentAtivo != null){
                currentAtivo.BackColor = Color.FromArgb(37,37, 37);
                currentAtivo.ForeColor = Color.Gainsboro;
                currentAtivo.TextAlign = ContentAlignment.MiddleLeft;
                currentAtivo.IconColor = Color.Gainsboro;
                currentAtivo.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentAtivo.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e){
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard_Content());
        }

        private void iconButton2_Click(object sender, EventArgs e){
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Vagas());
        }

        private void iconButton3_Click(object sender, EventArgs e){
            ActiveButton(sender, RGBColors.color1);
        }

        private void iconButton4_Click(object sender, EventArgs e){
            ActiveButton(sender, RGBColors.color1);
        }

        private void iconButton5_Click(object sender, EventArgs e){
            ActiveButton(sender, RGBColors.color2);
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e){ }

        private void OpenChildForm(Form childForm){
            if (currentChildForm != null) currentChildForm.Close();
            currentChildForm = childForm;
            
            //fim

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painelDesktop.Controls.Add(childForm);
            painelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset(){
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
        }

        //drag form - pra poder mexer a tela / arrastar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconHome_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PainelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
