namespace Metaverso
{
    public class Sistema
    {

        public int dato1 {get; set;}
        public string respuesta {get;}
        
        
        public  Sistema(){
            dato1=0;
        }
        public Sistema(int dato1){
            this.dato1= dato1;

        }
        public string multiplosArray( int[] valores){
            string cadena ="";
            for( int i= 0; i<valores.Length; i++ ){
               cadena = cadena +" "+ multiplo(valores[i]);
            }
            return cadena;

        }
        public string  multiplo(int dato1){
          
          string res= dato1+"";
          int  mult1=0;
          int  mult2=0;
         if(dato1>=0){
             mult1= dato1%5;
          mult2= dato1%3;
          
          if(mult1 ==0 && mult2==0){
            res= "Metaverso";
          }else if(mult1==0 && mult2!=0){
             res= "Verso";
          }else if(mult2==0 && mult1!=0){
              res="Meta";
          }
         }else{
          res = "introdusca un numero valido";
        }
        return res;
        }
        
    }
}