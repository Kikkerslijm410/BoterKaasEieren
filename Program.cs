namespace HelloWorld
{
    class Program{
        static void Main(string[] args){
            Zet zet1 = new Zet(); 
            Speler speler1 = new Speler();
            Coord coord1 = new Coord();
            string j;
            string i;
            int x;
            int y;
            i = Console.ReadLine();  
            j = Console.ReadLine();           
            x = Convert.ToInt32(i);
            y = Convert.ToInt32(j);
            coord1.setcoord(i, j);
        }
    }

    class Speler{

    }

    class Zet{
        int i = 0;
        public string getI(){
        if (i == 0){
            i++;
            return "X";
        }else{
            i--;
            return "O";
            }
        }
    }

    class Veld{        
        public void speler(){
            Console.WriteLine("0 0 0\n0 0 0\n0 0 0");
            Console.WriteLine("Geef het coordinaat:");
        }  

    }

    class Coord{
        public void setcoord(int i, int j){

        }
    }
}
