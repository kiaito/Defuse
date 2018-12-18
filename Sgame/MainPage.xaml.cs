using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
// Game Created by Levi Llewellyn
//CIST 2381
//I levi Llewellyn created this code withing this game. 
namespace Sgame
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 5).ToString();
        static int score = 0;
        static int count = 13;

        public MainPage()
        {
            InitializeComponent();
            myback.Source = ImageSource.FromFile("time-bomb_dynamite.jpg");
        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button match = sender as Button;
            //This is where the game is over


            if (match.Text == bomb)
            {
                cut.IsVisible = false;
                tw.IsVisible = false;
                myback.Source = ImageSource.FromFile("85.jpg");
                await DisplayAlert("****** Bomb Exploded *******", "GAME OVER", "Retry");
                bomb = new Random().Next(1, 6).ToString();
                score = 0;
                count = 13;
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                cut.IsVisible = true;
                tw.IsVisible = true;
                myback.Source = ImageSource.FromFile("time-bomb_dynamite.jpg");
                cut.Text = "Cut a Wire to Defuse the Bomb";
            }
            else if (score == 4)
            {
                score += 1;
                count -= 1;

                await DisplayAlert("****** Bomb Defused ******", "Score = " + score, "Conitnue");
                await DisplayAlert("Level 1 Completed", "Let make it a little more challenging", "Level 2");
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                cut.Text = "Complete Level 2";
                bomb = new Random().Next(1, 5).ToString();
            }
          
               else if(score > 4 && score < 9)
                {
                cut.Text = "Complete Level 2";
                score += 1;
                count -= 1;
                await DisplayAlert("****** Bomb Defused ******", "Score = " + score, "Conitnue");
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                bomb = new Random().Next(1, 5).ToString();
           

                 } 

            else if (score < 4 ){
                score += 1;
                count -= 1;
                await DisplayAlert("****** Bomb Defused ******", "Score = " + score, "Conitnue");
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                bomb = new Random().Next(1, 6).ToString();
            }

              else if (score == 9)
            
                {

                score += 1;
                count -= 1;
                await DisplayAlert("****** Bomb Defused ******", "Score = " + score, "Conitnue");
                    await DisplayAlert("Level 2 Completed", "Let make it a little more challenging", "Final Level");
                cut.Text = "Complete Level 3";
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                bomb = new Random().Next(1, 4).ToString();
               
            }
            else {
                cut.Text = "Complete Level 3";
                score += 1;
                count -= 1;
                await DisplayAlert("****** Bomb Defused ******", "Score = " + score, "Conitnue");
                tw.Text = "Defuse " + count + " Bombs to beat the game";
                bomb = new Random().Next(1, 4).ToString();
            }


            if (score > 4 && score < 9)
            {
                yel.IsVisible = false;
                yellb.IsVisible = false;
                yel.IsEnabled = false;
        }
            else if(score > 9 ){
                yel.IsVisible = false;
                yellb.IsVisible = false;
                yel.IsEnabled = false;
                graylb.IsVisible = false;
                graybtn.IsVisible = false;
                graybtn.IsEnabled = false;

            }
            else if(score <= 4){
                yel.IsVisible = true;
                yellb.IsVisible = true;
                yel.IsEnabled = true;
                graylb.IsVisible = true;
                graybtn.IsVisible = true;
                graybtn.IsEnabled = true;
            }
            if (score == 13){
                myback.Source = ImageSource.FromFile("ddfu.jpg");
                await DisplayAlert("Congraduration", "You Have defused all Bombs.", "Try Again");
                myback.Source = ImageSource.FromFile("time-bomb_dynamite.jpg");
                score = 0;
                count = 13;

                yel.IsVisible = true;
                yellb.IsVisible = true;
                yel.IsEnabled = true;
                graylb.IsVisible = true;
                graybtn.IsVisible = true;
                graybtn.IsEnabled = true;
                cut.Text = "Cut a Wire to Defuse the Bomb";
                tw.Text = "Defuse " + count + " Bombs to beat the game";

            }
                }
               

            }

    }

