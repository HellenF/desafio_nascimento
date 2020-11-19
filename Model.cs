

  using Microsoft.VisualBasic;
  using Main;  
  using System;

   class desafio_nascimento
   
     {

         static void Main(string[] args)
          {
            Idade Idade = new Idade();

            Idade.dataDeNascimento = DateTime(2020, 11 , 18);
            Idade.ImprimirDados();
            }
            public int64 idade
            {
            get 
            {
               return DateAndTime.DateDiff(DateInterval.Year, dataDeNascimento, DateTime.Now);
            }
            }
      



            






      
   