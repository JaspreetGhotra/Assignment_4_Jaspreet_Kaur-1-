namespace Assignment_4_Jaspreet_Kaur
{
    public partial class Form1 : Form
    {
        public Random Random_Number_Generator;

        //variables for score storage
        public int win_count { get; set; }
        public int loose_count { get; set; }
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlayRound(1);
        }
        private void PaperClick_Click(object sender, EventArgs e)
        {
            PlayRound(2);
        }
        private void ScissorClick_Click_1(object sender, EventArgs e)
        {
            PlayRound(3);
        }
        private void PlayRound(int your_choice)
        {
            //set up computer's choice
            int AI_Choice = Choose_AI_Choice();
            MessageBox.Show(CompareSelection(your_choice, AI_Choice), "Game Results: ");
        }
        private int Choose_AI_Choice()
        {
            //return computer's selection
            Random Random_Number_Generator = new Random();
            return Random_Number_Generator.Next(1, 4);
        }
        private String CompareSelection(int your_choice, int AI_Choice)
        {
            //set up a message value to show the result
            string message = string.Empty;

            //Compare values based on Player's selection
            switch (your_choice)
            {
                case 1: //you choose rock
                    switch (AI_Choice)
                    {
                        case 1:
                            message = "The computer' choice is rock same as you , so its a tie ";
                            break;
                        case 2:
                            loose_count++; message = "The computer's choice is paper . PAPER COVERS ROCK!! You looses and computer wins!";
                            break;
                        case 3:
                            win_count++; message = "The computer's choice is scissor .ROCK SMASHES SCISSOR!! You are the winner!";
                            break;
                    }
                    break;
                case 2: //you choose Paper
                    switch (AI_Choice)
                    {
                        case 1:
                            win_count++; message = "The computer' choice is rock .PAPER COVERS ROCK!! , so you are the winner!";
                            break;
                        case 2:
                            message = "The computer's choice is paper same as you . So it's a tie and no one is the winner!!";
                            break;
                        case 3:
                            loose_count++; message = "The computer's choice is scissor .SCISSOR CUTS THE PAPER!! You loose!";
                            break;
                    }
                    break;
                case 3: //you choose Scissor
                    switch (AI_Choice)
                    {
                        case 1:
                            loose_count++; message = "The computer's choice is rock .ROCK SMASHES SCISSOR!!, so you are the looser!";
                            break;
                        case 2:
                            win_count++; message = "The computer's choice is paper  . SCISSOR CUTS THE PAPER!! so you are the winner!!";
                            break;
                        case 3:
                            message = "The computer's choice is scissor same as you so , it's a tie and no one is the winner!!";
                            break;
                    }
                    break;
            }
            return message;
        }
       
        }

        //private void Looses_TextChanged(object sender, EventArgs e)
        
    }
