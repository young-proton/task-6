using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace task_6
{
    public partial class Form1 : Form
    {
        int computer;
        int comp_wins;
        int user_wins;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            comp_wins = 0;
            user_wins = 0;
            computer = rand.Next(1, 4);
        }

        private void PlayGame(int userChoice, string userImage)
        {
            pb_user.BackgroundImage = Image.FromFile(userImage);
            computer = rand.Next(1, 4);
            string compImage = "";
            string resultMessage = "";
            switch (computer)
            {
                case 1:
                    compImage = "rock.jpg";
                    resultMessage = userChoice == 1 ? "Tie" : userChoice == 2 ? "Win" : "Lose";
                    break;
                case 2:
                    compImage = "paper.jpg";
                    resultMessage = userChoice == 1 ? "Lose" : userChoice == 2 ? "Tie" : "Win";
                    break;
                case 3:
                    compImage = "scissors.jpg";
                    resultMessage = userChoice == 1 ? "Win" : userChoice == 2 ? "Lose" : "Tie";
                    break;
            }

            pb_comp.BackgroundImage = Image.FromFile(compImage);
            MessageBox.Show(resultMessage, resultMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultMessage == "Win")
            {
                user_wins++;
                res_user.Text = $"{user_wins}";
            }
            else if (resultMessage == "Lose")
            {
                comp_wins++;
                res_comp.Text = $"{comp_wins}";
            }


        }

        private void btn_rock_Click(object sender, EventArgs e)
        {
            PlayGame(1, "rock.jpg");
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            PlayGame(2, "PAPER.jpg");
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            PlayGame(3, "scissors.jpg");
        }
       
    }
}