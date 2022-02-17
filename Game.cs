// See https://aka.ms/new-console-template for more information
namespace Projet2
{
    public class Game
    {
        
        public char CurrentPlayer;
        public char[,] grid;

            public Game(){

            this.grid= new char[,] {{' ',' ',' '},
                                    {' ',' ',' '},
                                    {' ',' ',' '}};

                this.CurrentPlayer='O';
                }

            public void DisplayGrid(){
                for(int i=0;i<grid.GetLength(0);i++){
                    for(int j=0; j<grid.GetLength(1);j++){
                        Console.Write(this.grid[i,j]);
                        if(j!=2){
                            Console.Write("|");
                        }
                    }
                    Console.Write("\n");
                }
            }

        public void changeCurrentPlayer(){
            if(CurrentPlayer=='O'){
                CurrentPlayer='x';
            }else{
                CurrentPlayer='O';
            }
        }

         private int getPlayerValue(String text){
             Console.Write("Joueur: "+CurrentPlayer+"  Entrez le numero de la"+text+"\n");
             String value = Console.ReadLine();
             try{
                int i =System.Convert.ToInt32(value);
                if(i>2) {
                    return getPlayerValue(text);
                }
                return i;
             }catch (FormatException){
                 return getPlayerValue(text);
             }
            


         }

         public int getPlayerX(){
             String ligne = "ligne";
             int value = getPlayerValue(ligne);
             return value;

             }

                 public int getPlayerY(){
             String ligne = "colonne";
             int value = getPlayerValue(ligne);
             return value;

             }

             public bool isWin() { 
                 for(int i=0;i<3;i++){
                     if(grid[i,0]==grid[i,1] && grid[i,1]==grid[i,2] && grid[i,0]!=' '){
                         return true;
                     }
                 }
                     for(int j=0;j<3;j++){
                     if(grid[0,j]==grid[1,j] && grid[1,j]==grid[2,j] && grid[0,j]!=' '){
                         return true;
                     }

                 }
                 if (grid[0,0]==grid[1,1] && grid[1,1]==grid[2,2] && grid[0,0]!=' '){
                     return true;
                 }
                 if(grid[0,2]==grid[1,1] && grid[1,1]==grid[2,0] && grid[0,2]!=' '){
                     return true;
                 }
                return false;

             }
             

             public bool isNull() {
                 
                 for(int i=0;i<grid.GetLength(0);i++){
                for(int j=0; j<grid.GetLength(1);j++){
                    Console.Write(this.grid[i,j]);
                    
                    if(grid[i,j]==' '){
                        return false;
                    }
                }
                
            }
                return true; 
             }

         }
      } 
     
      
     
    

