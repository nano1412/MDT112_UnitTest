using System;

          class Program{
                    public static string Inputname(){
                              Console.Write("Input Name:");
                              return Console.ReadLine();
                    }

                    public static string Inputscore(){
                              Console.Write("Input Score");
                              return Console.ReadLine();
                    }

                    public static void PrintInputInfomation(string name, int inputScore, string grade){
                              Console.WriteLine("");
                              Console.WriteLine("*****************************");
                              Console.WriteLine("Name is {0}",name);
                              Console.WriteLine("Score is {0}",inputScore);
                              Console.WriteLine("Grade is {0}",grade);
                              Console.WriteLine("*****************************");
                              Console.WriteLine("");
                    }

                    public static string ConvertScoreToGrade(int score){
                              if(score > 100){ throw new Exception("Please input data 1 - 100");}

                              if(IsGradeA(score)){
                                        return "Grade A";
                              } else if (IsGradeBPlus(score)) {
                                        return "Grade B+";
                              } else if (IsGradeB(score)) {
                                        return "Grade B";
                              } else if (IsGradeCPlus(score)) {
                                        return "Grade C+";
                              } else if (IsGradeC(score)) {
                                        return "Grade C";
                              } else if (IsGradeDPlus(score)) {
                                        return "Grade D+";
                              } else if (IsGradeD(score)) {
                                        return "Grade D";
                              } else {return "Grade F!!";}       
                    }

                    public static bool IsGradeA(int score){
                              return (score <=100 && score >= 80)? true : false;
                    }

                    public static bool IsGradeBPlus(int score){
                              return score <80 && score >= 75;
                    }

                    public static bool IsGradeB(int score){
                              if (score <75 && score >= 70){
                                        return true;
                              }
                              return false;
                    }

                    public static bool IsGradeCPlus(int score){
                              return score <70 && score >= 65;
                    }

                    public static bool IsGradeC(int score){
                              return score <65 && score >= 60;
                    }

                    public static bool IsGradeDPlus(int score){
                              return score <60 && score >= 55;
                    }

                    public static bool IsGradeD(int score){
                              return score <55 && score >= 50;
                    }

                    static void Main(string[] args){
                              string name = Inputname();
                              string scoreString = Console.ReadLine();
                              int score = int.Parse(scoreString);
                              string grade = ConvertScoreToGrade(score);

                              PrintInputInfomation(name,score,grade);
                    }
}