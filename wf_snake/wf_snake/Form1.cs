using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake {
	public partial class Form1 : Form {

		// creating a list array for the snake
		private List<Circle> Snake = new List<Circle>();
		// creating single circle class called food
		private Circle food = new Circle();

		public Form1() {

			InitializeComponent();

			// set settings to defaults
			new Settings();

			// set game speed and start timer
			gameTimer.Interval = 1000 / Settings.Speed;
			gameTimer.Tick += UpdateScreen;
			gameTimer.Start();

			// start New game
			StartGame();
		}

		private void StartGame() {

			lblGameOver.Visible = false;

			// set settings to defaults
			new Settings();

			// create new player object
			Snake.Clear();
			Circle head = new Circle {
				X = 10,
				Y = 5
			};
			Snake.Add(head);

			lblScore.Text = Settings.Score.ToString();
			GenerateFood();
		}

		// place random food object
		private void GenerateFood() {
			int maxXPos = pbCanvas.Size.Width / Settings.Width;
			int maxYPos = pbCanvas.Size.Height / Settings.Height;

			Random random = new Random();
			food = new Circle {
				X = random.Next(0, maxXPos),
				Y = random.Next(0, maxYPos)
		};
		}

		private void UpdateScreen(object sender, EventArgs e) {

			// chech for game over
			if (Settings.GameOver) {
				// check if enter is pressed
				if (Input.KeyPressed(Keys.Enter)) {

					StartGame();
				}
			}
			else {
				if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
					Settings.direction = Direction.Right;
				else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
					Settings.direction = Direction.Left;
				else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
					Settings.direction = Direction.Up;
				else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
					Settings.direction = Direction.Down;

				MovePlayer();
			}

			pbCanvas.Invalidate();
		}

		private void pbCanvas_Paint(object sender, PaintEventArgs e) {

			Graphics canvas = e.Graphics;

			if (!Settings.GameOver) {

				//set colour of snake
				Brush snakeColour;
				
				// draw snake
				for (int i = 0; i < Snake.Count; i++) {
					
					if (i == 0)
						snakeColour = Brushes.Black; //draw head
					else
						snakeColour = Brushes.Green; //draw body

					// draw snake
					canvas.FillEllipse(snakeColour,
						new Rectangle(Snake[i].X * Settings.Width,
									  Snake[i].Y * Settings.Height,
									  Settings.Width, Settings.Height));

					// draw food
					canvas.FillEllipse(Brushes.Red,
						new Rectangle(food.X * Settings.Width,
									  food.Y * Settings.Height, 
									  Settings.Width, Settings.Height));
				}
			}
			else {
				string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress enter to try again";
				lblGameOver.Text = gameOver;
				lblGameOver.Visible = true;
			}
		}

		private void MovePlayer() {
			for (int i = Snake.Count - 1; i >= 0; i--) {
				
				// move head
				if ( i == 0) {
					switch (Settings.direction) {

						case Direction.Right:
							Snake[i].X++;
							break;
						case Direction.Left:
							Snake[i].X--;
							break;
						case Direction.Up:
							Snake[i].Y--;
							break;
						case Direction.Down:
							Snake[i].Y++;
							break;
					}

					// get maximum X and Y Pos
					int maxXPos = pbCanvas.Size.Width / Settings.Width;
					int maxYPos = pbCanvas.Size.Height / Settings.Height;

					// detect collision with game borders
					if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].X >= maxYPos) {
						Die();
					}

					// detect collision with body
					for (int j = 1; j < Snake.Count; j++) {
						if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y) {
							Die();
						}
					}

					// detect collision with food piece
					if (Snake[0].X == food.X && Snake[0].Y == food.Y) {
						Eat();
					}
				}
				else {
					// move body
					Snake[i].X = Snake[i - 1].X;
					Snake[i].Y = Snake[i - 1].Y;
				}
			}
		}

		private void Form1_KeyDown (object sender, KeyEventArgs e) {
			Input.ChangeState(e.KeyCode, true);
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e) {
			Input.ChangeState(e.KeyCode, false);
		}

		private void Eat() {

			// add circle to body
			Circle circle = new Circle {
				X = Snake[Snake.Count - 1].X,
				Y = Snake[Snake.Count - 1].Y
			};
			Snake.Add(circle);

			// update score
			Settings.Score += Settings.Points;
			lblScore.Text = Settings.Score.ToString();

			GenerateFood();
		}

		private void Die() {
			Settings.GameOver = true;
		}
	}
}
