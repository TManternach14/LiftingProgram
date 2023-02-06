namespace Lifting_Program
{
    public class Legs
    {
        public Legs(string textBox0, string textBox1, string textBox2, string textBox3, string textBox4)
        {
            textBox0 = textBox0;
            textBox1 = textBox1;
            textBox2 = textBox2;
            textBox3 = textBox3;
            textBox4 = textBox4;

            if (!File.Exists("Z:\\Practice\\" + textBox0 + ".txt")) // If file does not exists
            {
                File.Create("Z:\\Practice\\" + textBox0 + ".txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Z:\\Practice\\" + textBox0 + ".txt"))
                {
                    // Write text to .txt file
                    Tuple<string, string, string, string>[] lift = { Tuple.Create(textBox1, textBox2, textBox3, textBox4) };
                    //var exercise = Tuple.Create(textBox2.Text, textBox3.Text, textBox1.Text);
                    string header = String.Format("{0,-18}{1,-12}{2,-14}{3,-18}",
                                          "Lift", "Set", "Rep", "Date");

                    sw.WriteLine(header);
                    sw.WriteLine("----------------------------------------------------");
                    foreach (var item in lift)
                    {
                        sw.WriteLine("{0,-18} {1,-12} {2,-12}{3,-18}", item.Item1, item.Item2, item.Item3, item.Item4);
                    }

                }
            }
            else
            {
                bool containsDate;
                var file = File.ReadAllText("Z:\\Practice\\" + textBox0 + ".txt");
                containsDate = file.Contains(textBox4);

                if (containsDate == false)
                {

                    using (StreamWriter sw = File.AppendText("Z:\\Practice\\" + textBox0 + ".txt"))
                    {
                        // Write text to .txt file
                        Tuple<string, string, string, string>[] lift = { Tuple.Create(textBox1, textBox2, textBox3, textBox4) };
                        //var exercise = Tuple.Create(textBox2.Text, textBox3.Text, textBox1.Text);
                        string header = String.Format("{0,-18}{1,-12}{2,-14}{3,-18}",
                                              "Lift", "Set", "Rep", "Date");
                        sw.WriteLine("\n");
                        sw.WriteLine(header);
                        sw.WriteLine("----------------------------------------------------");
                        foreach (var item in lift)
                        {
                            sw.WriteLine("{0,-18} {1,-12} {2,-12}{3,-18}", item.Item1, item.Item2, item.Item3, item.Item4);
                        }
                    }

                }
                else
                {
                    using (StreamWriter sw = File.AppendText("Z:\\Practice\\" + textBox0 + ".txt"))
                    {
                        // Write text to .txt file
                        Tuple<string, string, string, string>[] lift = { Tuple.Create(textBox1, textBox2, textBox3, textBox4) };
                        //var exercise = Tuple.Create(textBox2.Text, textBox3.Text, textBox1.Text);
                        string header = String.Format("{0,-18}{1,-12}{2,-14}{3,-18}",
                                              "Lift", "Set", "Rep", "Date");

                        foreach (var item in lift)
                        {
                            sw.WriteLine("{0,-18} {1,-12} {2,-12}{3,-18}", item.Item1, item.Item2, item.Item3, item.Item4);
                        }
                    }
                }
            }
        }
    }

}