namespace Projet2;

public partial class Form1 : Form
{
    private Game game;
    public Form1()
    {
        InitializeComponent();
        game =  new Game();
    }
            public void restartGame(){
        for(int i=0; i<9;i++){
            tabCases[i].Text="";
        }
        game= new Game();
    }

    public void onCaseClick(object sender, System.EventArgs e){
            Case caseSelected = (Case) sender;
        if(caseSelected.Text.Equals("")){
            caseSelected.Text = game.CurrentPlayer+"";
            int x = caseSelected.getCoord()[0];
            int y = caseSelected.getCoord()[1];

            game.grid[y,x] = game.CurrentPlayer;

            
   if(game.isWin()){
                MessageBox.Show($"{game.CurrentPlayer} a gagné!");
                restartGame();
            }else if(game.isNull()){
                MessageBox.Show("Match null!!!");
                restartGame();
            }else{
                game.changeCurrentPlayer();
            }

        }
        
    }
}
