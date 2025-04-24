
//////////////////////////////////////////////////
// Windows Application Final Project:
// Caleb Neale
// Christopher Strand
// 1/24/2024
//////////////////////////////////////////////////

using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace evil_ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List of options for the Ultimate game of Rock Paper Scissors to keep the naming convention standard
        enum Choices
        {
            Rock,
            Gun,
            Lightning,
            Devil,
            Dragon,
            // this is lowercase on purpose to annoy people
            water,
            Air,
            Paper,
            Sponge,
            Wolf,
            Tree,
            Human,
            Snake,
            Scissors,
            Fire,
        }
        
        // Container for buttons for Selection Window
        private List<Button> buttons = new List<Button>();
        
        // Container of Images for Selection Window
        private List<Image> ourImages = new List<Image>();

        // Container with all the margin positions for the selection page
        private List<Thickness> startingPos = new List<Thickness>();

        // String for the file path for loading images
        static public String path;
        
        // for random generation
        private Random rand;

//////////////////////////////////////////////////
// Main
//////////////////////////////////////////////////
        public MainWindow()
        {
            // Initialize
            InitializeComponent();

            path = Environment.CurrentDirectory;

            rand = new Random();

            App.Current.Properties["Current_Page"] = Start_Page;

            CreateListOfButtons();
            CreateListOfImages();
            CreateListOfMargins();
            CreateListOfWorldEvents();
        }
        
        // Adds buttons for the selection screen into a list of buttons
        private void CreateListOfButtons()
        {
            buttons.Add(Impossible_Button0);
            buttons.Add(Impossible_Button1);
            buttons.Add(Impossible_Button2);
            buttons.Add(Impossible_Button3);
            buttons.Add(Impossible_Button4);
            buttons.Add(Impossible_Button5);
            buttons.Add(Impossible_Button6);
            buttons.Add(Impossible_Button7);
            buttons.Add(Impossible_Button8);
            buttons.Add(Impossible_Button9);
            buttons.Add(Impossible_ButtonA);
            buttons.Add(Impossible_ButtonB);
            buttons.Add(Impossible_ButtonC);
            buttons.Add(Impossible_ButtonD);
            buttons.Add(Impossible_ButtonE);
        }

        // Adds images for the buttons on the selection screen into a list of images
        private void CreateListOfImages(){
            ourImages.Add(image0);
            ourImages.Add(image1);
            ourImages.Add(image2);
            ourImages.Add(image3);
            ourImages.Add(image4);
            ourImages.Add(image5);
            ourImages.Add(image6);
            ourImages.Add(image7);
            ourImages.Add(image8);
            ourImages.Add(image9);
            ourImages.Add(imageA);
            ourImages.Add(imageB);
            ourImages.Add(imageC);
            ourImages.Add(imageD);
            ourImages.Add(imageE);
        }

        // Adds margins (starting positions) for the buttons on the selection screen in a list of "Thickness"
        private void CreateListOfMargins(){
            startingPos.Add(new Thickness(86, 603, 0, 0));
            startingPos.Add(new Thickness(521, 511, 0, 0));
            startingPos.Add(new Thickness(420, 679, 0, 0));
            startingPos.Add(new Thickness(226, 179, 0, 0));
            startingPos.Add(new Thickness(136, 248, 0, 0));
            startingPos.Add(new Thickness(0, 731, 0, 0));
            startingPos.Add(new Thickness(136, 679, 0, 0));
            startingPos.Add(new Thickness(485, 603, 0, 0));
            startingPos.Add(new Thickness(348, 179, 0, 0));
            startingPos.Add(new Thickness(86, 323, 0, 0));
            startingPos.Add(new Thickness(36, 396, 0, 0));
            startingPos.Add(new Thickness(521, 0, 0, 0));
            startingPos.Add(new Thickness(420, 248, 0, 0));
            startingPos.Add(new Thickness(470, 323, 0, 0));
            startingPos.Add(new Thickness(36, 516, 0, 0));
        }

        // Adds tuples of strings (world events) and ints (year it occurred) for the AgeChecker screen in a list of tuples
        private void CreateListOfWorldEvents(){
            worldEvents.Add(new Tuple<string, int>("Passage of the 19th Amendment Granting Women the right to vote", 1920));
            worldEvents.Add(new Tuple<string, int>("Founding of the Chinese Communist Party", 1921));
            worldEvents.Add(new Tuple<string, int>("Britain Declared Limited Independence for Egypt Relinquishing control of the colony", 1922));
            worldEvents.Add(new Tuple<string, int>("The Great Kanto Earthquake. A 7.9 magnitude earthquake. Death Toll: 140,000", 1923));
            worldEvents.Add(new Tuple<string, int>("Vladimir Lenin dies and Joseph Stalin becomes the leader of the Soviet Union", 1924));
            worldEvents.Add(new Tuple<string, int>("The Scope Monkey Trial: A Tennessee High School teacher is put on trial and convicted for teaching Evolution in the classroom", 1925));
            worldEvents.Add(new Tuple<string, int>("United States introduces the Numbered Highway System", 1926));
            worldEvents.Add(new Tuple<string, int>("Charles Lindbergh becomes the first person to fly over the Atlantic Ocean nonstop", 1927));
            worldEvents.Add(new Tuple<string, int>("Amelia Earhart becomes the first woman to pilot a plane across the Atlantic Ocean", 1928));
            worldEvents.Add(new Tuple<string, int>("The \"Black Tuesday\" Wall Street stock market crash", 1929));
            worldEvents.Add(new Tuple<string, int>("Ho Chi Minh founds the Communist Party of Vietnam in efforts to oust the French colonial occupiers", 1930));
            worldEvents.Add(new Tuple<string, int>("Empire State building completes construction and receives inauguration by U.S. President Herbert Hoover", 1931));
            worldEvents.Add(new Tuple<string, int>("Hitler is granted German citizenship 7 years after renouncing his Austrian citizenship", 1932));
            worldEvents.Add(new Tuple<string, int>("Franklin Delano Roosevelt becomes President of the United States of America", 1933));
            worldEvents.Add(new Tuple<string, int>("The Night of the Long Knives: Hitler has Nazi Storm Troopers arrest and execute 700-1000 left-wing politcal enemies and \"undesirable\" right-wing politcal allies, becoming the dictator of Germany", 1934));
            worldEvents.Add(new Tuple<string, int>("U.S. President Roosevelt signs into law the Social Security Act as part of his progressive \"New Deal\" policy", 1935));
            worldEvents.Add(new Tuple<string, int>("African-American sprinter Jesse Owens from Alabama wins four Olympic gold medals in the Summer Olympics in Nazi controlled Berlin", 1936));
            worldEvents.Add(new Tuple<string, int>("The United Automobile Workers launches first successful strike, occupying their factory building for 44 days. They won the right to have bathroom breaks, to talk in the lunchroom, and pause production when factory workers died or became seriously injured on the factory floor", 1937));
            worldEvents.Add(new Tuple<string, int>("The Night of Broken Glass: Jewish businesses, homes, and houses are destroyed across Germany and Austria and tens of thousands of Jews were rounded up and sent to concentration camps", 1938));
            worldEvents.Add(new Tuple<string, int>("World War II officially starts with the German invasion of Poland", 1939));
            worldEvents.Add(new Tuple<string, int>("the first McDonald's is opened by brothers Richard and Maurice McDonald in San Bernardino, California", 1940));
            worldEvents.Add(new Tuple<string, int>("Japan attacks the U.S. naval base of Pearl Harbor, damaging or destroying 19 vessels and killing 2,403 people", 1941));
            worldEvents.Add(new Tuple<string, int>("U.S. Troops arrive in Northern Ireland, marking the beginning of direct U.S. involvement in the European theater of World War II", 1942));
            worldEvents.Add(new Tuple<string, int>("Swiss chemist Albert Hoffman experiences the first ever LSD trip after accidently exposing himself to an experimental lysergic compound he created in his lab years prior", 1943));
            worldEvents.Add(new Tuple<string, int>("D-Day: the Allied forces launch the largest single day military campaign by storming 5 beaches in Normandy, France", 1944));
            worldEvents.Add(new Tuple<string, int>("The U.S. drops atomic bombs on Hiroshima and Nagasaki, killing nearly 200,000 civilians, despite military intelligence that Japan was preparing to surrender", 1945));
            worldEvents.Add(new Tuple<string, int>("The First programmable computer is created at University of Pennsylvania", 1946));
            worldEvents.Add(new Tuple<string, int>("The Indian subcontent Gains Independence from Britain. The subcontinent is partitioned into India and Pakistan. India deports all it's Muslim citizens to Pakistan and an estimated 1 million people die during the migration", 1947));
            worldEvents.Add(new Tuple<string, int>("The British colony of Israel gains independence and signs an armistice to end the Arab-Israeli War, successfully gaining control over a significant portion of land belonging to the Palestinians", 1948));
            worldEvents.Add(new Tuple<string, int>("NATO (North Atlantic Treaty Organization) is founded amidst rising Cold War tensions with the Soviet Union", 1949));
            worldEvents.Add(new Tuple<string, int>("The North Korean People's Army marches into South Korea to reunify the two nations, prompting U.S. President Truman to declare war on North Korea", 1950));
            worldEvents.Add(new Tuple<string, int>("Julius and Ethel Rosenberg are convicted of espionage by the U.S. for passing along Atomic secrets to the Soviet Union during World War II", 1951));
            worldEvents.Add(new Tuple<string, int>("The U.S. detonates the first hydrogen bomb which is 1000x more powerful than the atomic bombs dropped on Hiroshima and Nagasaki", 1952));
            worldEvents.Add(new Tuple<string, int>("The fundemntal behavior and double-helix structure of DNA is discovered by Cambridge University scientists James Watson and Francis Crick", 1953));
            worldEvents.Add(new Tuple<string, int>("The U.S. Supreme Court ruled on Brown vs. Board of Education, ruling racially segregated schools to be unconstitutional", 1954));
            worldEvents.Add(new Tuple<string, int>("Rosa Parks is arrested in Montgomery Alabama for refusing to give up her seat to a white passenger, the inciting incident for the Montgomery Bus Boycott", 1955));
            worldEvents.Add(new Tuple<string, int>("Hungary is invaded by the Soviet Union and the city of Budapest is occupied to crush a rebellion in the region. Thousands of Hungarian citizens were killed in the first few days.", 1956));
            worldEvents.Add(new Tuple<string, int>("The Little Rock Nine: U.S. President Eisenhower mobolizes federal troops to protect 9 black students from racially motivated violence by fellow students and thousands of protestors as they attend a formerly whites only high school in Arkansas", 1957));
            worldEvents.Add(new Tuple<string, int>("U.S successfully launches its first satellite into space 3 months after the Soviet Union launches the first ever satellite into space: Sputnik", 1958));
            worldEvents.Add(new Tuple<string, int>("Fidel Castro's rebels successfully liberate Cuba U.S.-backed dictatorship of Fulgencio Batista", 1959));
            worldEvents.Add(new Tuple<string, int>("Four African American College Students - Ezell A. Blair, Franklin E. McCain, Joseph A. McNeil and David L. Richmond - sit down at a white's only lunch counter in North Carolina and are denied service. They refuse to leave, starting a 6-month Sit-in protest", 1960));
            worldEvents.Add(new Tuple<string, int>("The Berlin Wall is built, separating U.S. controlled West Berlin from Soviet controlled East Berlin for almost 3 decades", 1961));
            worldEvents.Add(new Tuple<string, int>("Cuban Missile Crisis: The U.S. blockades the sovereign nation of Cuba after it is discovered the Soviet Union is building Cuba nuclear missile installations.", 1962));
            worldEvents.Add(new Tuple<string, int>("U.S President John F. Kennedy is assassinated in Dallas, Tx. His alleged assassin, Lee Harvey Oswald, is murdered by a Dallas nightclub owner, Jack Ruby, before he could stand trial", 1963));
            worldEvents.Add(new Tuple<string, int>("U.S. Presient Lyndon B. Johnson signs the Civil Rights Act into law", 1964));
            worldEvents.Add(new Tuple<string, int>("Bloody Sunday: Alabama state troopers murder civil rights protester Jimmy Lee Jackson and hospitilize an additional 50 protesters", 1965));
            worldEvents.Add(new Tuple<string, int>("The Adam West Batman TV series debutes", 1966));
            worldEvents.Add(new Tuple<string, int>("The Six-Day War: Israel launches an attack against Egypt. The resulting conflict ends with Israel in control of all Palestinian territory as well as parts of Egypt, Syria, and Jordan", 1967));
            worldEvents.Add(new Tuple<string, int>("Rev. Dr. Martin Luther King, Jr. was assassinated. James Earl Ray pled guilty to the crime, but Dr. Kings family still maintain James's innocense, alleging coercion and coverup by the FBI", 1968));
            worldEvents.Add(new Tuple<string, int>("Neil Armstrong, Buzz Aldrin, and Michael Collins become the first people to ever walk on the moon", 1969));
            worldEvents.Add(new Tuple<string, int>("U.S. President Richard Nixon expands the Vietnam War by authorizing the invasion of Vietnam's neighbor, Cambodia", 1970));
            worldEvents.Add(new Tuple<string, int>("The Pentagon Papers are released, exposing serious crimes and coverups by the U.S. government during the Vietnam War, as well as clandestine attacks against Laos and Cambodia", 1971));
            worldEvents.Add(new Tuple<string, int>("Britain suspends the provincial government of Northern Ireland, taking direct control of the region, amidst increasingly violent clashes between pro-Independence and pro-Britain paramilitary organizations", 1972));
            worldEvents.Add(new Tuple<string, int>("The U.S. Supreme Court rules on Roe v. Wade, establishing the \"Right to Privacy\", the foundation for Abortion Rights, HIPAA, FERPA, and Interacial Marriage rights. The ruling was overturned by the Supreme Court in 2022", 1973));
            worldEvents.Add(new Tuple<string, int>("U.S. President Nixon resigns amidst the Watergate scandal in which the Nixon administration attempted to coverup the botched burglary of the Democratic National Committee headquarters by the Nixon administration", 1974));
            worldEvents.Add(new Tuple<string, int>("North Vietnam, two years after the last U.S. troops leave, successfully captures the city of Saigon and reunify North and South Vietnam", 1975));
            worldEvents.Add(new Tuple<string, int>("The Concorde, a model of commercial jet capable of breaking the speed of sound, had it's first commercial flight. Only 16 Concordes were ever put into service", 1976));
            worldEvents.Add(new Tuple<string, int>("The Commodore PET is unveiled at the Consumer Electronics Show in Chicago", 1977));
            worldEvents.Add(new Tuple<string, int>("Jonestown: 900+ people (including 276 children) die in a mass murder-suicide via powdered drink mix dosed with cyanide. The incident was related to the \"Peoples Temple\" cult led by Jim Jones", 1978));
            worldEvents.Add(new Tuple<string, int>("Iran experiences a revolution, dissolving the U.S. supported Monarchy in favor of an Islamic Theocracy", 1979));
            worldEvents.Add(new Tuple<string, int>("Ronald Reagan is elected President of the U.S., ushering in the economic decline of the Working Class in the U.S.", 1980));
            worldEvents.Add(new Tuple<string, int>("The first reported cases of HIV/AIDS are found in the U.S. killing 500 Americans within a year of discovery", 1981));
            worldEvents.Add(new Tuple<string, int>("E.T. the Extra-Terrestrial by Steven Spielberg hit theaters", 1982));
            worldEvents.Add(new Tuple<string, int>("The Advanced Research Projects Agency Network (ARPANET) transitions to the standard TCP/IP protocol of the World Wide Web. The protocol is the future cornerstone of the internet", 1983));
            worldEvents.Add(new Tuple<string, int>("The worst industrial disaster in world history occurs in Bhopal, India. 30 tons of methyl isocyanate are released by Union Carbide Corp., killing 15,000 and permanently injuring another 600,000", 1984));
            worldEvents.Add(new Tuple<string, int>("U.S. President Reagan successfully reduces tax rates for the wealthy by more than half, lowering rates to levels not seen since the lead up to the Great Depression", 1985));
            worldEvents.Add(new Tuple<string, int>("The Challenger Space Shuttle explodes during launch, killing 7 astronauts", 1986));
            worldEvents.Add(new Tuple<string, int>("Black Monday: The stock market crash during U.S. President Reagan's administration. The crash is considered worse than the 1929 crash leading into the Great Depression and its effects were still be felt leading up to the 2008 \"Financial Crisis\"", 1987));
            worldEvents.Add(new Tuple<string, int>("Christopher Strand was born", 1988));
            worldEvents.Add(new Tuple<string, int>("The Berlin Wall is torn down by the citizens of Berlin immediately following an announcement from the East Berlin Communist Party regarding lifting all travel restrictions between West and East Berlin. By Nightfall, the \"Greatest Street Party in the History of the World\" was underway", 1989));
            worldEvents.Add(new Tuple<string, int>("The Hubble Space Telescope launches", 1990));
            worldEvents.Add(new Tuple<string, int>("Operation Desert Storm: Iraq, led by Saddam Hussein, invades and occupies it's neighbor, Kuwait. The U.S. military, with support from Saudi Arabia, \"secure\" Kuwait (and it's significant oil assets) from Iraqi control", 1991));
            worldEvents.Add(new Tuple<string, int>("End of the Cold War: U.S. President George H.W. Bush and Russian President Boris Yeltsin formally declare an end to Cold War hostilities. The nation of Russia declares independence for 11 of its former soviet states, marking the dissolution of the Soviet Union", 1992));
            worldEvents.Add(new Tuple<string, int>("The Treaty of the EU (European Union) is signed, standardizing regulations across the European member nations simplfying immigration and trade between them, creating a unified economic power that could engage on equal footing with large econimic powers like the U.S. or China", 1993));
            worldEvents.Add(new Tuple<string, int>("Amazon.Com launched as an online bookstore based out of Seattle", 1994));
            worldEvents.Add(new Tuple<string, int>("Oklahoma City Bombing: The Alfred P. Murrah Federal Building in Oklahoma City is hit by a truck-bomb attack, killing 168 people, including 19 children who were in a childcare center in the building. The attack was orchestrated by two far-right domestic terrorists who will not be named", 1995));
            worldEvents.Add(new Tuple<string, int>("A sheep is successfully cloned. Dolly was the first ever clone of a mammal and, being a sheep, was born in Scotland", 1996));
            worldEvents.Add(new Tuple<string, int>("IBM's Deep Blue becomes the first AI machine to beat a world chess champion", 1997));
            worldEvents.Add(new Tuple<string, int>("Stanford Universtiy Ph.D. students Larry Page and Sergey Brin launch Google.Com", 1998));
            worldEvents.Add(new Tuple<string, int>("NATO initiates their first-ever military campaign against the Federal Republic of Yugoslavia to expel Serbian forces from Kosovo during the Kosovo War", 1999));
            worldEvents.Add(new Tuple<string, int>("The creation of the International Space Station. While the project had been in progress for some time, the station finally had its first temporary residents: Bill Shepherd, Yuri Gidzenko, and Sergei Krikalev", 2000));
            worldEvents.Add(new Tuple<string, int>("9/11", 2001));
            worldEvents.Add(new Tuple<string, int>("U.S. President George W. Bush signs the Homeland Security Act, creating the Department of Homeland Security which oversees \"security\" matters like protecting infrastructure from cyber-attacks and managing the new U.S. Immigration and Customs Enforcement (ICE) agency", 2002));
            worldEvents.Add(new Tuple<string, int>("The U.S. Military and allies invade Iraq with the intention of destroying Iraq’s alleged \"weapons of mass destruction\"; the weapons are never found. U.S.-backed rebels overthrow the Hussein regime, creating a destabilized nation that has still not recovered", 2003));
            worldEvents.Add(new Tuple<string, int>("Facebook.com is launched at Harvard University by student Mark Zuckerburg. The first version was a site for male students to rate the bodies and appearance of their female counterparts", 2004));
            worldEvents.Add(new Tuple<string, int>("Hurricane Katrina overwhelms New Orleans, causing 1,833 to die from the initial storm and $161 Billion in damages. Due to a poorly maintained levee system, failure of the U.S. government to mobolize food, water, and rescue, and local white nationalist paramilitary groups descending on black neighborhoods to \"Hunt N*****s\", the death toll rose", 2005));
            worldEvents.Add(new Tuple<string, int>("Former Iraqi Dictator Saddam Hussein tried and hanged by New Iraqi regime. An attendee of the private military execution used a hidden cell phone to record the event and uploaded it to the internet.", 2006));
            worldEvents.Add(new Tuple<string, int>("Apple launches the original IPhone", 2007));
            worldEvents.Add(new Tuple<string, int>("The Dow plunges, in part due to the U.S. subprime mortgage market crash, sending economies around the world crashing and beginning the Great Recession. Economists argue if the Great Recession has ended", 2008));
            worldEvents.Add(new Tuple<string, int>("Barack Obama becomes the first African-American U.S. President, entering office just 3 months after the worst economic collapse in U.S. history", 2009));
            worldEvents.Add(new Tuple<string, int>("U.S. President Obama signs the Affordable Care Act into law which, among other things, expanded medicare and medicaid access for poor, elderly, and disabled citizens, made it illegal for insurance companies to deny coverage to citizens with pre-existing health conditions, and made it so children could stay on parents health care plans till they turned 25", 2010));
            worldEvents.Add(new Tuple<string, int>("U.S. President Obama orders the clandestine assassination of Osama bin Laden, mastermind of 9/11 and leader of al Qaeda, after his whereabouts are discovered in Pakistan", 2011));
            worldEvents.Add(new Tuple<string, int>("The CERN’s Large Hadron Collider discovers a new particle widely believed to be the elusive Higgs boson, known as the “God Particle,” which is thought to be a fundamental component of the universe.", 2012));
            worldEvents.Add(new Tuple<string, int>("computer security consultant Edward Snowden revealed a series secret programs from numerous U.S. and European government surveillance operations, including illegal monitoring by the U.S. National Security Agency (NSA) on U.S. citizens domestically. He now resides in exile in Moscow and the NSA is still operating its monitoring program", 2013));
            worldEvents.Add(new Tuple<string, int>("Russian escalates its decade long Cold War with Ukraine by \"annexing\" a region of Ukraine called the Crimean Peninsula. Russian Dictator Vladimir Putin sought the area partly because of its strategic value, but also his well known obsession with rebuilding the Russian Empire", 2014));
        }

        // Shuts Down App when main window is closed
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            App.Current.Shutdown();
        }

//////////////////////////////////////////////////
// Selection Page Puzzle
//////////////////////////////////////////////////
        // Function that calls functions for moving buttons and changing their content until they are all identical
        private void Impossible_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            // Make the instructions disappear after interacting with the first button
            Choosing_instructions.Visibility = Visibility.Hidden;
            Choosing_instructions.IsEnabled = false;

            if (!compare_Impossible_Content())
            {
                Choices Choice = (Choices)rand.Next(0, 15);

                move_Button((Button)sender, rand);
                
                Image pic = ((Image)((Button)sender).Content);

                pic.Source = new BitmapImage(new Uri($@"{path}/images/{(Choices)((int)Choice)}.jpg"));

                ((Button)sender).Content = pic;
                ((Button)sender).Tag = (Choices)((int)Choice);

                if (Choice == Choices.Air)
                {
                    ((Button)sender).Opacity = 0.15;
                }
                else if (((Button)sender).Opacity < 1)
                {
                    ((Button)sender).Opacity = 1;
                }
            }
        }
        
        // Checks if all buttons are the same
        private bool compare_Impossible_Content()
        {
            //grab the file path of the first buttom
            String btn1 = (ourImages[0].Source).ToString();
            String btn2;

            for(int i = 1; i < buttons.Count(); i++)
            {
                //grab the file path of next button
                btn2 = ((ourImages[i].Source).ToString());

                //compare the two buttons
                if (!(btn1.Equals(btn2))) { 
                    return false;
                }
                
                //set the second button to the current button
                btn1 = btn2;


            }

            return true;

        }
        
        // Function that moves the buttons and keeps them in bounds 
        private void move_Button(Button m, Random rand){
            Thickness mgn = m.Margin;

            if (rand.Next(0, 10) >= 5){

                //Move Right
                mgn.Left += rand.Next(100, 150);
                
                if (501 <= mgn.Left){
                    mgn.Left = 200.0;
                }
            }
            else{
                //Move left
                mgn.Left -= rand.Next(100, 150);

                if (0 >= mgn.Left){
                    mgn.Left = 300.0;
                }
            }

            if (rand.Next(0, 10) >= 5){
                //Move up
                mgn.Top -= rand.Next(50, 100);
                if (0 >= mgn.Top){
                    mgn.Top = 200.0;

                }
            }
            else{
                //Move down
                mgn.Top += rand.Next(50, 100);
                if (807 <= mgn.Top){
                    mgn.Top = 500.0;
                }
            }


            m.Margin = mgn;
        }

        // What happens when you finally have an option to select a button on the selection page
        private void Impossible_Button_Click(object sender, RoutedEventArgs e)
        {
            if (compare_Impossible_Content())
            {
                App.Current.Properties["PlayerChoice"] = ((Impossible_Button0.Tag).ToString()) switch{
                    ("Rock") => 0,
                    ("Gun") => 1,
                    ("Lightning") => 2,
                    ("Devil") => 3,
                    ("Dragon") => 4,
                    ("water") => 5,
                    ("Air") => 6,
                    ("Paper") => 7,
                    ("Sponge") => 8,
                    ("Wolf") => 9,
                    ("Tree") => 10,
                    ("Human") => 11,
                    ("Snake") => 12,
                    ("Scissors") => 13,
                    ("Fire") => 14,
                };
                // takes you to the confirmation page
                MessageBox.Show($"You have selected {((Choices)((int)App.Current.Properties["PlayerChoice"])).ToString()}.\nYou will now be asked to perform a simple task to confirm you are not a robot.");
                ConfirmationHandler();
            }
        }

        // Assigns images to the buttons on the selection screen
        private void Images(object? sender = null, RoutedEventArgs? e = null)
        {
            try
            {
                Choices choice = 0;
                // loads images from filepath into the images in the buttons, iterating through the enum list of option names
                foreach (Image pic in ourImages)
                {
                    pic.Source = new BitmapImage(new Uri($@"{path}/images/{choice.ToString()}.jpg"));
                    choice++;
                }
                // resets
                choice = 0;
                // loads enum list of option names into the buttons tags
                foreach (Button butt in buttons)
                {
                    butt.Tag = choice;
                    if (choice == Choices.Air)
                    {
                        butt.Opacity = 0.15;
                    }
                    choice++;
                }
                // loads the margin starting positions for each button
                int pos = 0;
                foreach (Button butt in buttons)
                {
                    butt.Margin = startingPos[pos];
                    pos++;
                }
            }
            // should only throw if there is an issue with the filepath for loading images
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong:\n{0}", ex.Message);
            }
        }

//////////////////////////////////////////////////
// Starting Page Puzzle
//////////////////////////////////////////////////
        // Button click that changes from Starting Grid to Selection Grid
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            //You might just not get to start the game
            if(rand.Next(0,51) > 40) {
                ReturnToSelection();
            } 
        }
     
//////////////////////////////////////////////////
// Directions Window
//////////////////////////////////////////////////
        // Button click to open the directions window
        private void Directions_Click(object sender, RoutedEventArgs e)
        {
            // Creates direction window
            DirectionWindow temp = new DirectionWindow();
            // Opens direction window
            temp.Show();
            // Deactivates the directions button so you can't look at the directions again
            Directions.Visibility = Visibility.Collapsed;
            Directions.IsEnabled = false;
        }

//////////////////////////////////////////////////
// Hub for moving between Grids for Puzzles
//////////////////////////////////////////////////
        // Function to determine which confirmation hellscape you need to deal with
        private void ConfirmationHandler()
        {
            ResetPuzzles();
            // Create list of Confirmation Page grids
            Grid[] confirmOption = new Grid[] { Counter, AirPump, PleaseWait, AgeChecker, Button_Maze };
            // Deactivate current Grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Collapsed;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = false;
            // Change current page to selected Grid name
            App.Current.Properties["Current_Page"] = confirmOption[rand.Next(0, confirmOption.Length)];
            // Activate new grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Visible;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = true;
        }

        // Function for returning to the selection screen
        private void ReturnToSelection()
        {
            // deactivate current grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Collapsed;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = false;
            App.Current.Properties["Current_Page"] = Moving_Button;
            // reset the selection window
            Choosing_instructions.Visibility = Visibility.Visible;
            Choosing_instructions.IsEnabled = true;
            Directions.Visibility = Visibility.Visible;
            Directions.IsEnabled = true;
            Images();
            // activate new grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Visible;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = true;
        }

        // Function for going to the end page
        private void ReachTheEnd()
        {
            // deactivate current grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Collapsed;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = false;
            App.Current.Properties["Current_Page"] = End_Page;
            End_Lable.Content = $"You have successfully completed the confirmation process.\nYou picked {((Choices)((int)App.Current.Properties["PlayerChoice"])).ToString()}\nHow would you like to proceed?";
            // activate new grid
            ((Grid)App.Current.Properties["Current_Page"]).Visibility = Visibility.Visible;
            ((Grid)App.Current.Properties["Current_Page"]).IsEnabled = true;
            App.Current.Properties["CanWin"] = false;
        }

        // Check to see if confirmation was successful
        public void Confirmed(int result)
        {
            switch (result)
            {
                // If the puzzle has determined that an additional confirmation page puzzle is necessary
                case 0: ConfirmationHandler(); break;
                // If the puzzle has determined that the user needs to return to the selection page puzzle
                case -1: ReturnToSelection(); break;
                // If the puzzle has determined that the user has earned the privilege of completing a single round of Ultimate Rock Paper Scissors
                case 1: ReachTheEnd(); break;
            };       
        }

        private void ResetPuzzles()
        {
            // from Air Pump Puzzle
            hitTop = false;
            AirContainer.Value = 0;
            // from Counter Puzzle
            countStarted = false;
            Display_Goal.Visibility = Visibility.Collapsed;
            Count_Label1.Visibility = Visibility.Collapsed;
            Count_Label2.Visibility = Visibility.Collapsed;
            Count_Label3.Visibility = Visibility.Collapsed;
            Count_Label4.Visibility = Visibility.Collapsed;
            // from AgeChecker Puzzle
            EventConfirm.IsEnabled = false;
            EventConfirm.Visibility = Visibility.Collapsed;
            EventDetails.IsEnabled = false;
            EventDetails.Visibility = Visibility.Collapsed;
            EventBefore.IsEnabled = false;
            EventBefore.Visibility = Visibility.Collapsed;
            EventAfter.IsEnabled = false;
            EventAfter.Visibility = Visibility.Collapsed;
            GetAge.Visibility = Visibility.Visible;
            GetAge.IsEnabled = true;
            TheAge.Visibility = Visibility.Visible;
            TheAge.IsEnabled = true;
            TheAge.Text = "Enter Your Age";
            // from PleaseWait Puzzle
            WaitLabel.Content = "Please Wait";
            WaitLabel.Cursor = Cursors.Wait;
            WaitLabel.FontSize = 48;
            WaitLabel.FontFamily = new FontFamily("Old English Text MT");
        }
        
//////////////////////////////////////////////////
// Air Pump Puzzle
//////////////////////////////////////////////////
        //
        private bool hitTop = new bool();
        
        //Checks the value of the slider every time it is moved
        //When the slider hits 10, a boolean is enabled so that when it hits 0 again, the progress bar will increment

        private void Pump_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (((Slider)sender).Value == 10)
            {
                hitTop = true;
            }

            if (((Slider)sender).Value == 0 && hitTop)
            {
                AirContainer.Value += 1.0;
                hitTop = false;
            }

            if(AirContainer.Value == 100)
            {
                //Will always go to a new confirmation page
                Confirmed(0);
            }
        }

//////////////////////////////////////////////////
// Counter Puzzle
//////////////////////////////////////////////////
        //
        private int count = new int();
        //
        private int target = new int();
        //
        private bool countStarted = new bool();
        // Number of times the user has hit 999
        private int countRotations = new int();
        //
        private void Increment_Click(object sender, RoutedEventArgs e)
        {
            if(!countStarted)
            {
                target = rand.Next(0, 101);
                string msg = "To prove you are a human please count up to " + target;
                MessageBox.Show(msg);
                countRotations = 0;
                Display_Goal.Content = $"Goal: {target}";
                Display_Goal.FontSize = 12;
                countStarted = true;
            }
            count += rand.Next(1, 5);
            CountBox.Content = count;
            if(count == target)
            {
                //reset the counter
                count = 0;
                target = -1;
                countStarted = false;
                CountBox.Content = count;
                //50% chance of taking you to a new confirmation or actually finishing
                Confirmed(rand.Next(0, 2));
            }
            else if(count > 999)
            {
                count = 0;
                CountBox.Content = count;
                //5% chance of just taking you back to the beginning if you hit 999
                if(rand.Next(0,20) > 18)
                {
                    MessageBox.Show("Yeah, you're inability to count shows you're a robot\nReturning to Selection Page");
                    Confirmed(-1);
                }
                else
                {
                    // outcome after every rotation
                    switch (countRotations)
                    {
                        case 0:
                            MessageBox.Show("Clearly, you need some help.");
                            Display_Goal.Visibility = Visibility.Visible;
                            break;
                        case 1:
                            MessageBox.Show("I guess the text was bit small");
                            Display_Goal.FontSize = 16;
                            break;
                        case 2:
                            MessageBox.Show("The number you're supposed to count to is at the bottom of the screen!!!");
                            Display_Goal.FontSize = 20;
                            break;
                        case 3:
                            Count_Label1.Content = "Look THIS Way\nVVVV";
                            Count_Label1.Visibility = Visibility.Visible;
                            Display_Goal.FontSize = 24;
                            break;
                        case 4:
                            Count_Label1.Visibility = Visibility.Collapsed;
                            Count_Label2.Content = "You are so bad at this";
                            Count_Label2.Visibility = Visibility.Visible;
                            Display_Goal.FontSize = 36;
                            break;
                        case 5:
                            Count_Label2.Visibility = Visibility.Collapsed;
                            Count_Label3.Content = "Like, really, really bad at this";
                            Count_Label3.Visibility = Visibility.Visible;
                            Display_Goal.FontSize = 48;
                            break;
                        case 6:
                            MessageBox.Show("Let's try this!");
                            Count_Label1.Content = Display_Goal.Content;
                            Count_Label2.Content = Display_Goal.Content;
                            Count_Label3.Content = Display_Goal.Content;
                            Count_Label4.Content = Display_Goal.Content;
                            Count_Label1.Visibility = Visibility.Visible;
                            Count_Label2.Visibility = Visibility.Visible;
                            Count_Label3.Visibility = Visibility.Visible;
                            Count_Label4.Visibility = Visibility.Visible;
                            Display_Goal.FontSize = 72;
                            break;
                        default:
                            Count_Label1.Visibility = Visibility.Collapsed;
                            Count_Label2.Visibility = Visibility.Collapsed;
                            Count_Label3.Visibility = Visibility.Collapsed;
                            Count_Label4.Visibility = Visibility.Collapsed;
                            Display_Goal.Content = "Wow, You Suck";
                            break; 
                    }
                    countRotations++;
                }
            }
        }

//////////////////////////////////////////////////
// PleaseWait Puzzle
//////////////////////////////////////////////////
        //
        private int countClicks = new int();
        //
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            countClicks++;
            if (countClicks < 10)
            {
                WaitLabel.Content = "Curse you";
                return;
            }
            else if (countClicks < 20)
            {
                WaitLabel.Content = "I said wait gosh darn you!";
                return;
            }
            else if( countClicks < 30)
            {
                WaitLabel.Content = "HAHA! Take That!";
                WaitLabel.Cursor = Cursors.None;
                return;
            }
            else if(countClicks < 35)
            {
                WaitLabel.Content = "fooey..";
                WaitLabel.FontFamily = new FontFamily("Arial");
                WaitLabel.FontSize = 12;
                return;
            }
            else if(countClicks < 37)
            {
                WaitLabel.Content = "I'm still not going to give your cursor back";
                return;
            }
            else if(countClicks < 40)
            {
                WaitLabel.Content = "Good grief, WAIT! SIT! DOWN!";
                return;
            }
            else if(countClicks < 41)
            {
                WaitLabel.Content = "";
                MessageBox.Show("The label man has died");
                MessageBox.Show("I have a letter I was bidden to show thee");
                MessageBox.Show("According to all known laws\nof aviation,\nthere is no way a bee\nshould be able to fly.\nIts wings are too small to get\nits fat little body off the ground.\nThe bee, of course, flies anyway\nbecause bees don't care\nwhat humans think is impossible.\nYellow, black. Yellow, black.\nYellow, black. Yellow, black.\nOoh, black and yellow!\nLet's shake it up a little.\nBarry! Breakfast is ready!\nOoming!\nHang on a second.\nHello?\n- Barry?\n- Adam?\n- Oan you believe this is happening?\n- I can't. I'll pick you up.\nLooking sharp.\nUse the stairs. Your father\npaid good money for those.\nSorry. I'm excited.\nHere's the graduate.\nWe're very proud of you, son.\nA perfect report card, all B's.\nVery proud.\nMa! I got a thing going here.\n- You got lint on your fuzz.\n- Ow! That's me!\n- Wave to us! We'll be in row 118,000.\n- Bye!\nBarry, I told you,\nstop flying in the house!\n- Hey, Adam.\n- Hey, Barry.\n- Is that fuzz gel?\n");
                MessageBox.Show("- A little. Special day, graduation.\nNever thought I'd make it.\nThree days grade school,\nthree days high school.\nThose were awkward.\nThree days college. I'm glad I took\na day and hitchhiked around the hive.\nYou did come back different.\n- Hi, Barry.\n- Artie, growing a mustache? Looks good.\n- Hear about Frankie?\n- Yeah.\n- You going to the funeral?\n- No, I'm not going.\nEverybody knows,\nsting someone, you die.\nDon't waste it on a squirrel.\nSuch a hothead.\nI guess he could have\njust gotten out of the way.\nI love this incorporating\nan amusement park into our day.\nThat's why we don't need vacations.\nBoy, quite a bit of pomp...\nunder the circumstances.\n- Well, Adam, today we are men.\n- We are!\n- Bee-men.\n- Amen!\nHallelujah!\nStudents, faculty, distinguished bees,\nplease welcome Dean Buzzwell.\nWelcome, New Hive Oity\ngraduating class of...\n...9:15.\nThat concludes our ceremonies.\nAnd begins your career\n");
                MessageBox.Show("at Honex Industries!\nWill we pick ourjob today?\nI heard it's just orientation.\nHeads up! Here we go.\nKeep your hands and antennas\ninside the tram at all times.\n- Wonder what it'll be like?\n- A little scary.\nWelcome to Honex,\na division of Honesco\nand a part of the Hexagon Group.\nThis is it!\nWow.\nWow.\nWe know that you, as a bee,\nhave worked your whole life\nto get to the point where you\ncan work for your whole life.\nHoney begins when our valiant Pollen\nJocks bring the nectar to the hive.\nOur top-secret formula\nis automatically color-corrected,\nscent-adjusted and bubble-contoured\ninto this soothing sweet syrup\nwith its distinctive\ngolden glow you know as...\nHoney!\n- That girl was hot.\n- She's my cousin!\n- She is?\n- Yes, we're all cousins.\n- Right. You're right.\n- At Honex, we constantly strive\nto improve every aspect\nof bee existence.\nThese bees are stress-testing\na new helmet technology.\n- What do you think he makes?");
                MessageBox.Show("\n- Not enough.\nHere we have our latest advancement,\nthe Krelman.\n- What does that do?\n- Oatches that little strand of honey\nthat hangs after you pour it.\nSaves us millions.\nOan anyone work on the Krelman?\nOf course. Most bee jobs are\nsmall ones. But bees know\nthat every small job,\nif it's done well, means a lot.\nBut choose carefully\nbecause you'll stay in the job\nyou pick for the rest of your life.\nThe same job the rest of your life?\nI didn't know that.\nWhat's the difference?\nYou'll be happy to know that bees,\nas a species, haven't had one day off\nin 27 million years.\nSo you'll just work us to death?\nWe'll sure try.\nWow! That blew my mind!\n\"What's the difference?\"\nHow can you say that?\nOne job forever?\nThat's an insane choice to have to make.\nI'm relieved. Now we only have\nto make one decision in life.\nBut, Adam, how could they\nnever have told us that?\nWhy would you question anything?\nWe're bees.\n");
                MessageBox.Show("We're the most perfectly\nfunctioning society on Earth.\nYou ever think maybe things\nwork a little too well here?\nLike what? Give me one example.\nI don't know. But you know\nwhat I'm talking about.\nPlease clear the gate.\nRoyal Nectar Force on approach.\nWait a second. Oheck it out.\n- Hey, those are Pollen Jocks!\n- Wow.\nI've never seen them this close.\nThey know what it's like\noutside the hive.\nYeah, but some don't come back.\n- Hey, Jocks!\n- Hi, Jocks!\nYou guys did great!\nYou're monsters!\nYou're sky freaks! I love it! I love it!\n- I wonder where they were.\n- I don't know.\nTheir day's not planned.\nOutside the hive, flying who knows\nwhere, doing who knows what.\nYou can'tjust decide to be a Pollen\nJock. You have to be bred for that.\nRight.\nLook. That's more pollen\nthan you and I will see in a lifetime.\nIt's just a status symbol.\nBees make too much of it.\nPerhaps. Unless you're wearing it\nand the ladies see you wearing it.");
                MessageBox.Show("\nThose ladies?\nAren't they our cousins too?\nDistant. Distant.\nLook at these two.\n- Oouple of Hive Harrys.\n- Let's have fun with them.\nIt must be dangerous\nbeing a Pollen Jock.\nYeah. Once a bear pinned me\nagainst a mushroom!\nHe had a paw on my throat,\nand with the other, he was slapping me!\n- Oh, my!\n- I never thought I'd knock him out.\nWhat were you doing during this?\nTrying to alert the authorities.\nI can autograph that.\nA little gusty out there today,\nwasn't it, comrades?\nYeah. Gusty.\nWe're hitting a sunflower patch\nsix miles from here tomorrow.\n- Six miles, huh?\n- Barry!\nA puddle jump for us,\nbut maybe you're not up for it.\n- Maybe I am.\n- You are not!\nWe're going 0900 at J-Gate.\nWhat do you think, buzzy-boy?\nAre you bee enough?\nI might be. It all depends\non what 0900 means.\nHey, Honex!\nDad, you surprised me.\nYou decide what you're interested in?\n- Well, there's a lot of choices.\n- But you only get one.\n");
                MessageBox.Show("Do you ever get bored\ndoing the same job every day?\nSon, let me tell you about stirring.\nYou grab that stick, and you just\nmove it around, and you stir it around.\nYou get yourself into a rhythm.\nIt's a beautiful thing.\nYou know, Dad,\nthe more I think about it,\nmaybe the honey field\njust isn't right for me.\nYou were thinking of what,\nmaking balloon animals?\nThat's a bad job\nfor a guy with a stinger.\nJanet, your son's not sure\nhe wants to go into honey!\n- Barry, you are so funny sometimes.\n- I'm not trying to be funny.\nYou're not funny! You're going\ninto honey. Our son, the stirrer!\n- You're gonna be a stirrer?\n- No one's listening to me!\nWait till you see the sticks I have.\nI could say anything right now.\nI'm gonna get an ant tattoo!\nLet's open some honey and celebrate!\nMaybe I'll pierce my thorax.\nShave my antennae.\nShack up with a grasshopper. Get\na gold tooth and call everybody \"dawg\"!\nI'm so proud.\n- We're starting work today!");
                MessageBox.Show("\n- Today's the day.\nOome on! All the good jobs\nwill be gone.\nYeah, right.\nPollen counting, stunt bee, pouring,\nstirrer, front desk, hair removal...\n- Is it still available?\n- Hang on. Two left!\nOne of them's yours! Oongratulations!\nStep to the side.\n- What'd you get?\n- Picking crud out. Stellar!\nWow!\nOouple of newbies?\nYes, sir! Our first day! We are ready!\nMake your choice.\n- You want to go first?\n- No, you go.\nOh, my. What's available?\nRestroom attendant's open,\nnot for the reason you think.\n- Any chance of getting the Krelman?\n- Sure, you're on.\nI'm sorry, the Krelman just closed out.\nWax monkey's always open.\nThe Krelman opened up again.\nWhat happened?\nA bee died. Makes an opening. See?\nHe's dead. Another dead one.\nDeady. Deadified. Two more dead.\nDead from the neck up.\nDead from the neck down. That's life!\nOh, this is so hard!\nHeating, cooling,\nstunt bee, pourer, stirrer,\nhumming, inspector number seven,\n");
                MessageBox.Show("lint coordinator, stripe supervisor,\nmite wrangler. Barry, what\ndo you think I should... Barry?\nBarry!\nAll right, we've got the sunflower patch\nin quadrant nine...\nWhat happened to you?\nWhere are you?\n- I'm going out.\n- Out? Out where?\n- Out there.\n- Oh, no!\nI have to, before I go\nto work for the rest of my life.\nYou're gonna die! You're crazy! Hello?\nAnother call coming in.\nIf anyone's feeling brave,\nthere's a Korean deli on 83rd\nthat gets their roses today.\nHey, guys.\n- Look at that.\n- Isn't that the kid we saw yesterday?\nHold it, son, flight deck's restricted.\nIt's OK, Lou. We're gonna take him up.\nReally? Feeling lucky, are you?\nSign here, here. Just initial that.\n- Thank you.\n- OK.\nYou got a rain advisory today,\nand as you all know,\nbees cannot fly in rain.\nSo be careful. As always,\nwatch your brooms,\nhockey sticks, dogs,\nbirds, bears and bats.\nAlso, I got a couple of reports\nof root beer being poured on us.\n");
                MessageBox.Show("Murphy's in a home because of it,\nbabbling like a cicada!\n- That's awful.\n- And a reminder for you rookies,\nbee law number one,\nabsolutely no talking to humans!\nAll right, launch positions!\nBuzz, buzz, buzz, buzz! Buzz, buzz,\nbuzz, buzz! Buzz, buzz, buzz, buzz!\nBlack and yellow!\nHello!\nYou ready for this, hot shot?\nYeah. Yeah, bring it on.\nWind, check.\n- Antennae, check.\n- Nectar pack, check.\n- Wings, check.\n- Stinger, check.\nScared out of my shorts, check.\nOK, ladies,\nlet's move it out!\nPound those petunias,\nyou striped stem-suckers!\nAll of you, drain those flowers!\nWow! I'm out!\nI can't believe I'm out!\nSo blue.\nI feel so fast and free!\nBox kite!\nWow!\nFlowers!\nThis is Blue Leader.\nWe have roses visual.\nBring it around 30 degrees and hold.\nRoses!\n30 degrees, roger. Bringing it around.\nStand to the side, kid.\nIt's got a bit of a kick.\nThat is one nectar collector!\n- Ever see pollination up close?\n- No, sir.\n");
                MessageBox.Show("I pick up some pollen here, sprinkle it\nover here. Maybe a dash over there,\na pinch on that one.\nSee that? It's a little bit of magic.\nThat's amazing. Why do we do that?\nThat's pollen power. More pollen, more\nflowers, more nectar, more honey for us.\nOool.\nI'm picking up a lot of bright yellow.\nOould be daisies. Don't we need those?\nOopy that visual.\nWait. One of these flowers\nseems to be on the move.\nSay again? You're reporting\na moving flower?\nAffirmative.\nThat was on the line!\nThis is the coolest. What is it?\nI don't know, but I'm loving this color.\nIt smells good.\nNot like a flower, but I like it.\nYeah, fuzzy.\nOhemical-y.\nOareful, guys. It's a little grabby.\nMy sweet lord of bees!\nOandy-brain, get off there!\nProblem!\n- Guys!\n- This could be bad.\nAffirmative.\nVery close.\nGonna hurt.\nMama's little boy.\nYou are way out of position, rookie!\nOoming in at you like a missile!\nHelp me!\nI don't think these are flowers.\n");
                MessageBox.Show("- Should we tell him?\n- I think he knows.\nWhat is this?!\nMatch point!\nYou can start packing up, honey,\nbecause you're about to eat it!\nYowser!\nGross.\nThere's a bee in the car!\n- Do something!\n- I'm driving!\n- Hi, bee.\n- He's back here!\nHe's going to sting me!\nNobody move. If you don't move,\nhe won't sting you. Freeze!\nHe blinked!\nSpray him, Granny!\nWhat are you doing?!\nWow... the tension level\nout here is unbelievable.\nI gotta get home.\nOan't fly in rain.\nOan't fly in rain.\nOan't fly in rain.\nMayday! Mayday! Bee going down!\nKen, could you close\nthe window please?\nKen, could you close\nthe window please?\nOheck out my new resume.\nI made it into a fold-out brochure.\nYou see? Folds out.\nOh, no. More humans. I don't need this.\nWhat was that?\nMaybe this time. This time. This time.\nThis time! This time! This...\nDrapes!\nThat is diabolical.\nIt's fantastic. It's got all my special\nskills, even my top-ten favorite movies.\n");
                MessageBox.Show("What's number one? Star Wars?\nNah, I don't go for that...\n...kind of stuff.\nNo wonder we shouldn't talk to them.\nThey're out of their minds.\nWhen I leave a job interview, they're\nflabbergasted, can't believe what I say.\nThere's the sun. Maybe that's a way out.\nI don't remember the sun\nhaving a big 75 on it.\nI predicted global warming.\nI could feel it getting hotter.\nAt first I thought it was just me.\nWait! Stop! Bee!\nStand back. These are winter boots.\nWait!\nDon't kill him!\nYou know I'm allergic to them!\nThis thing could kill me!\nWhy does his life have\nless value than yours?\nWhy does his life have any less value\nthan mine? Is that your statement?\nI'm just saying all life has value. You\ndon't know what he's capable of feeling.\nMy brochure!\nThere you go, little guy.\nI'm not scared of him.\nIt's an allergic thing.\nPut that on your resume brochure.\nMy whole face could puff up.\nMake it one of your special skills.\nKnocking someone out\n");
                MessageBox.Show("is also a special skill.\nRight. Bye, Vanessa. Thanks.\n- Vanessa, next week? Yogurt night?\n- Sure, Ken. You know, whatever.\n- You could put carob chips on there.\n- Bye.\n- Supposed to be less calories.\n- Bye.\nI gotta say something.\nShe saved my life.\nI gotta say something.\nAll right, here it goes.\nNah.\nWhat would I say?\nI could really get in trouble.\nIt's a bee law.\nYou're not supposed to talk to a human.\nI can't believe I'm doing this.\nI've got to.\nOh, I can't do it. Oome on!\nNo. Yes. No.\nDo it. I can't.\nHow should I start it?\n\"You like jazz?\" No, that's no good.\nHere she comes! Speak, you fool!\nHi!\nI'm sorry.\n- You're talking.\n- Yes, I know.\nYou're talking!\nI'm so sorry.\nNo, it's OK. It's fine.\nI know I'm dreaming.\nBut I don't recall going to bed.\nWell, I'm sure this\nis very disconcerting.\nThis is a bit of a surprise to me.\nI mean, you're a bee!\nI am. And I'm not supposed\nto be doing this,\nbut they were all trying to kill me.\n");
                MessageBox.Show("And if it wasn't for you...\nI had to thank you.\nIt's just how I was raised.\nThat was a little weird.\n- I'm talking with a bee.\n- Yeah.\nI'm talking to a bee.\nAnd the bee is talking to me!\nI just want to say I'm grateful.\nI'll leave now.\n- Wait! How did you learn to do that?\n- What?\nThe talking thing.\nSame way you did, I guess.\n\"Mama, Dada, honey.\" You pick it up.\n- That's very funny.\n- Yeah.\nBees are funny. If we didn't laugh,\nwe'd cry with what we have to deal with.\nAnyway...\nOan I...\n...get you something?\n- Like what?\nI don't know. I mean...\nI don't know. Ooffee?\nI don't want to put you out.\nIt's no trouble. It takes two minutes.\n- It's just coffee.\n- I hate to impose.\n- Don't be ridiculous!\n- Actually, I would love a cup.\nHey, you want rum cake?\n- I shouldn't.\n- Have some.\n- No, I can't.\n- Oome on!\nI'm trying to lose a couple micrograms.\n- Where?\n- These stripes don't help.\nYou look great!\nI don't know if you know\n");
                MessageBox.Show("anything about fashion.\nAre you all right?\nNo.\nHe's making the tie in the cab\nas they're flying up Madison.\nHe finally gets there.\nHe runs up the steps into the church.\nThe wedding is on.\nAnd he says, \"Watermelon?\nI thought you said Guatemalan.\nWhy would I marry a watermelon?\"\nIs that a bee joke?\nThat's the kind of stuff we do.\nYeah, different.\nSo, what are you gonna do, Barry?\nAbout work? I don't know.\nI want to do my part for the hive,\nbut I can't do it the way they want.\nI know how you feel.\n- You do?\n- Sure.\nMy parents wanted me to be a lawyer or\na doctor, but I wanted to be a florist.\n- Really?\n- My only interest is flowers.\nOur new queen was just elected\nwith that same campaign slogan.\nAnyway, if you look...\nThere's my hive right there. See it?\nYou're in Sheep Meadow!\nYes! I'm right off the Turtle Pond!\nNo way! I know that area.\nI lost a toe ring there once.\n- Why do girls put rings on their toes?\n- Why not?\n");
                MessageBox.Show("- It's like putting a hat on your knee.\n- Maybe I'll try that.\n- You all right, ma'am?\n- Oh, yeah. Fine.\nJust having two cups of coffee!\nAnyway, this has been great.\nThanks for the coffee.\nYeah, it's no trouble.\nSorry I couldn't finish it. If I did,\nI'd be up the rest of my life.\nAre you...?\nOan I take a piece of this with me?\nSure! Here, have a crumb.\n- Thanks!\n- Yeah.\nAll right. Well, then...\nI guess I'll see you around.\nOr not.\nOK, Barry.\nAnd thank you\nso much again... for before.\nOh, that? That was nothing.\nWell, not nothing, but... Anyway...\nThis can't possibly work.\nHe's all set to go.\nWe may as well try it.\nOK, Dave, pull the chute.\n- Sounds amazing.\n- It was amazing!\nIt was the scariest,\nhappiest moment of my life.\nHumans! I can't believe\nyou were with humans!\nGiant, scary humans!\nWhat were they like?\nHuge and crazy. They talk crazy.\nThey eat crazy giant things.\nThey drive crazy.\n- Do they try and kill you, like on TV?\n");
                MessageBox.Show("- Some of them. But some of them don't.\n- How'd you get back?\n- Poodle.\nYou did it, and I'm glad. You saw\nwhatever you wanted to see.\nYou had your \"experience.\" Now you\ncan pick out yourjob and be normal.\n- Well...\n- Well?\nWell, I met someone.\nYou did? Was she Bee-ish?\n- A wasp?! Your parents will kill you!\n- No, no, no, not a wasp.\n- Spider?\n- I'm not attracted to spiders.\nI know it's the hottest thing,\nwith the eight legs and all.\nI can't get by that face.\nSo who is she?\nShe's... human.\nNo, no. That's a bee law.\nYou wouldn't break a bee law.\n- Her name's Vanessa.\n- Oh, boy.\nShe's so nice. And she's a florist!\nOh, no! You're dating a human florist!\nWe're not dating.\nYou're flying outside the hive, talking\nto humans that attack our homes\nwith power washers and M-80s!\nOne-eighth a stick of dynamite!\nShe saved my life!\nAnd she understands me.\nThis is over!\nEat this.\nThis is not over! What was that?\n- They call it a crumb.\n");
                MessageBox.Show("- It was so stingin' stripey!\nAnd that's not what they eat.\nThat's what falls off what they eat!\n- You know what a Oinnabon is?\n- No.\nIt's bread and cinnamon and frosting.\nThey heat it up...\nSit down!\n...really hot!\n- Listen to me!\nWe are not them! We're us.\nThere's us and there's them!\nYes, but who can deny\nthe heart that is yearning?\nThere's no yearning.\nStop yearning. Listen to me!\nYou have got to start thinking bee,\nmy friend. Thinking bee!\n- Thinking bee.\n- Thinking bee.\nThinking bee! Thinking bee!\nThinking bee! Thinking bee!\nThere he is. He's in the pool.\nYou know what your problem is, Barry?\nI gotta start thinking bee?\nHow much longer will this go on?\nIt's been three days!\nWhy aren't you working?\nI've got a lot of big life decisions\nto think about.\nWhat life? You have no life!\nYou have no job. You're barely a bee!\nWould it kill you\nto make a little honey?\nBarry, come out.\nYour father's talking to you.\n");
                MessageBox.Show("Martin, would you talk to him?\nBarry, I'm talking to you!\nYou coming?\nGot everything?\nAll set!\nGo ahead. I'll catch up.\nDon't be too long.\nWatch this!\nVanessa!\n- We're still here.\n- I told you not to yell at him.\nHe doesn't respond to yelling!\n- Then why yell at me?\n- Because you don't listen!\nI'm not listening to this.\nSorry, I've gotta go.\n- Where are you going?\n- I'm meeting a friend.\nA girl? Is this why you can't decide?\nBye.\nI just hope she's Bee-ish.\nThey have a huge parade\nof flowers every year in Pasadena?\nTo be in the Tournament of Roses,\nthat's every florist's dream!\nUp on a float, surrounded\nby flowers, crowds cheering.\nA tournament. Do the roses\ncompete in athletic events?\nNo. All right, I've got one.\nHow come you don't fly everywhere?\nIt's exhausting. Why don't you\nrun everywhere? It's faster.\nYeah, OK, I see, I see.\nAll right, your turn.\nTiVo. You can just freeze live TV?\nThat's insane!\nYou don't have that?\n");
                MessageBox.Show("We have Hivo, but it's a disease.\nIt's a horrible, horrible disease.\nOh, my.\nDumb bees!\nYou must want to sting all those jerks.\nWe try not to sting.\nIt's usually fatal for us.\nSo you have to watch your temper.\nVery carefully.\nYou kick a wall, take a walk,\nwrite an angry letter and throw it out.\nWork through it like any emotion:\nAnger, jealousy, lust.\nOh, my goodness! Are you OK?\nYeah.\n- What is wrong with you?!\n- It's a bug.\nHe's not bothering anybody.\nGet out of here, you creep!\nWhat was that? A Pic 'N' Save circular?\nYeah, it was. How did you know?\nIt felt like about 10 pages.\nSeventy-five is pretty much our limit.\nYou've really got that\ndown to a science.\n- I lost a cousin to Italian Vogue.\n- I'll bet.\nWhat in the name\nof Mighty Hercules is this?\nHow did this get here?\nOute Bee, Golden Blossom,\nRay Liotta Private Select?\n- Is he that actor?\n- I never heard of him.\n- Why is this here?\n- For people. We eat it.\nYou don't have\n");
                MessageBox.Show("enough food of your own?\n- Well, yes.\n- How do you get it?\n- Bees make it.\n- I know who makes it!\nAnd it's hard to make it!\nThere's heating, cooling, stirring.\nYou need a whole Krelman thing!\n- It's organic.\n- It's our-ganic!\nIt's just honey, Barry.\nJust what?!\nBees don't know about this!\nThis is stealing! A lot of stealing!\nYou've taken our homes, schools,\nhospitals! This is all we have!\nAnd it's on sale?!\nI'm getting to the bottom of this.\nI'm getting to the bottom\nof all of this!\nHey, Hector.\n- You almost done?\n- Almost.\nHe is here. I sense it.\nWell, I guess I'll go home now\nand just leave this nice honey out,\nwith no one around.\nYou're busted, box boy!\nI knew I heard something.\nSo you can talk!\nI can talk.\nAnd now you'll start talking!\nWhere you getting the sweet stuff?\nWho's your supplier?\nI don't understand.\nI thought we were friends.\nThe last thing we want\nto do is upset bees!\nYou're too late! It's ours now!\n");
                MessageBox.Show("You, sir, have crossed\nthe wrong sword!\nYou, sir, will be lunch\nfor my iguana, Ignacio!\nWhere is the honey coming from?\nTell me where!\nHoney Farms! It comes from Honey Farms!\nOrazy person!\nWhat horrible thing has happened here?\nThese faces, they never knew\nwhat hit them. And now\nthey're on the road to nowhere!\nJust keep still.\nWhat? You're not dead?\nDo I look dead? They will wipe anything\nthat moves. Where you headed?\nTo Honey Farms.\nI am onto something huge here.\nI'm going to Alaska. Moose blood,\ncrazy stuff. Blows your head off!\nI'm going to Tacoma.\n- And you?\n- He really is dead.\nAll right.\nUh-oh!\n- What is that?!\n- Oh, no!\n- A wiper! Triple blade!\n- Triple blade?\nJump on! It's your only chance, bee!\nWhy does everything have\nto be so doggone clean?!\nHow much do you people need to see?!\nOpen your eyes!\nStick your head out the window!\nFrom NPR News in Washington,\nI'm Oarl Kasell.\nBut don't kill no more bugs!\n- Bee!\n");
                MessageBox.Show("- Moose blood guy!!\n- You hear something?\n- Like what?\nLike tiny screaming.\nTurn off the radio.\nWhassup, bee boy?\nHey, Blood.\nJust a row of honey jars,\nas far as the eye could see.\nWow!\nI assume wherever this truck goes\nis where they're getting it.\nI mean, that honey's ours.\n- Bees hang tight.\n- We're all jammed in.\nIt's a close community.\nNot us, man. We on our own.\nEvery mosquito on his own.\n- What if you get in trouble?\n- You a mosquito, you in trouble.\nNobody likes us. They just smack.\nSee a mosquito, smack, smack!\nAt least you're out in the world.\nYou must meet girls.\nMosquito girls try to trade up,\nget with a moth, dragonfly.\nMosquito girl don't want no mosquito.\nYou got to be kidding me!\nMooseblood's about to leave\nthe building! So long, bee!\n- Hey, guys!\n- Mooseblood!\nI knew I'd catch y'all down here.\nDid you bring your crazy straw?\nWe throw it in jars, slap a label on it,\nand it's pretty much pure profit.\nWhat is this place?\n");
                MessageBox.Show("A bee's got a brain\nthe size of a pinhead.\nThey are pinheads!\nPinhead.\n- Oheck out the new smoker.\n- Oh, sweet. That's the one you want.\nThe Thomas 3000!\nSmoker?\nNinety puffs a minute, semi-automatic.\nTwice the nicotine, all the tar.\nA couple breaths of this\nknocks them right out.\nThey make the honey,\nand we make the money.\n\"They make the honey,\nand we make the money\"?\nOh, my!\nWhat's going on? Are you OK?\nYeah. It doesn't last too long.\nDo you know you're\nin a fake hive with fake walls?\nOur queen was moved here.\nWe had no choice.\nThis is your queen?\nThat's a man in women's clothes!\nThat's a drag queen!\nWhat is this?\nOh, no!\nThere's hundreds of them!\nBee honey.\nOur honey is being brazenly stolen\non a massive scale!\nThis is worse than anything bears\nhave done! I intend to do something.\nOh, Barry, stop.\nWho told you humans are taking\nour honey? That's a rumor.\nDo these look like rumors?\nThat's a conspiracy theory.\n");
                MessageBox.Show("These are obviously doctored photos.\nHow did you get mixed up in this?\nHe's been talking to humans.\n- What?\n- Talking to humans?!\nHe has a human girlfriend.\nAnd they make out!\nMake out? Barry!\nWe do not.\n- You wish you could.\n- Whose side are you on?\nThe bees!\nI dated a cricket once in San Antonio.\nThose crazy legs kept me up all night.\nBarry, this is what you want\nto do with your life?\nI want to do it for all our lives.\nNobody works harder than bees!\nDad, I remember you\ncoming home so overworked\nyour hands were still stirring.\nYou couldn't stop.\nI remember that.\nWhat right do they have to our honey?\nWe live on two cups a year. They put it\nin lip balm for no reason whatsoever!\nEven if it's true, what can one bee do?\nSting them where it really hurts.\nIn the face! The eye!\n- That would hurt.\n- No.\nUp the nose? That's a killer.\nThere's only one place you can sting\nthe humans, one place where it matters.\nHive at Five, the hive's only\n");
                MessageBox.Show("full-hour action news source.\nNo more bee beards!\nWith Bob Bumble at the anchor desk.\nWeather with Storm Stinger.\nSports with Buzz Larvi.\nAnd Jeanette Ohung.\n- Good evening. I'm Bob Bumble.\n- And I'm Jeanette Ohung.\nA tri-county bee, Barry Benson,\nintends to sue the human race\nfor stealing our honey,\npackaging it and profiting\nfrom it illegally!\nTomorrow night on Bee Larry King,\nwe'll have three former queens here in\nour studio, discussing their new book,\nOlassy Ladies,\nout this week on Hexagon.\nTonight we're talking to Barry Benson.\nDid you ever think, \"I'm a kid\nfrom the hive. I can't do this\"?\nBees have never been afraid\nto change the world.\nWhat about Bee Oolumbus?\nBee Gandhi? Bejesus?\nWhere I'm from, we'd never sue humans.\nWe were thinking\nof stickball or candy stores.\nHow old are you?\nThe bee community\nis supporting you in this case,\nwhich will be the trial\nof the bee century.\nYou know, they have a Larry King\nin the human world too.\n");
                MessageBox.Show("It's a common name. Next week...\nHe looks like you and has a show\nand suspenders and colored dots...\nNext week...\nGlasses, quotes on the bottom from the\nguest even though you just heard 'em.\nBear Week next week!\nThey're scary, hairy and here live.\nAlways leans forward, pointy shoulders,\nsquinty eyes, very Jewish.\nIn tennis, you attack\nat the point of weakness!\nIt was my grandmother, Ken. She's 81.\nHoney, her backhand's a joke!\nI'm not gonna take advantage of that?\nQuiet, please.\nActual work going on here.\n- Is that that same bee?\n- Yes, it is!\nI'm helping him sue the human race.\n- Hello.\n- Hello, bee.\nThis is Ken.\nYeah, I remember you. Timberland, size\nten and a half. Vibram sole, I believe.\nWhy does he talk again?\nListen, you better go\n'cause we're really busy working.\nBut it's our yogurt night!\nBye-bye.\nWhy is yogurt night so difficult?!\nYou poor thing.\nYou two have been at this for hours!\nYes, and Adam here\nhas been a huge help.\n");
                MessageBox.Show("- Frosting...\n- How many sugars?\nJust one. I try not\nto use the competition.\nSo why are you helping me?\nBees have good qualities.\nAnd it takes my mind off the shop.\nInstead of flowers, people\nare giving balloon bouquets now.\nThose are great, if you're three.\nAnd artificial flowers.\n- Oh, those just get me psychotic!\n- Yeah, me too.\nBent stingers, pointless pollination.\nBees must hate those fake things!\nNothing worse\nthan a daffodil that's had work done.\nMaybe this could make up\nfor it a little bit.\n- This lawsuit's a pretty big deal.\n- I guess.\nYou sure you want to go through with it?\nAm I sure? When I'm done with\nthe humans, they won't be able\nto say, \"Honey, I'm home,\"\nwithout paying a royalty!\nIt's an incredible scene\nhere in downtown Manhattan,\nwhere the world anxiously waits,\nbecause for the first time in history,\nwe will hear for ourselves\nif a honeybee can actually speak.\nWhat have we gotten into here, Barry?\n");
                MessageBox.Show("It's pretty big, isn't it?\nI can't believe how many humans\ndon't work during the day.\nYou think billion-dollar multinational\nfood companies have good lawyers?\nEverybody needs to stay\nbehind the barricade.\n- What's the matter?\n- I don't know, I just got a chill.\nWell, if it isn't the bee team.\nYou boys work on this?\nAll rise! The Honorable\nJudge Bumbleton presiding.\nAll right. Oase number 4475,\nSuperior Oourt of New York,\nBarry Bee Benson v. the Honey Industry\nis now in session.\nMr. Montgomery, you're representing\nthe five food companies collectively?\nA privilege.\nMr. Benson... you're representing\nall the bees of the world?\nI'm kidding. Yes, Your Honor,\nwe're ready to proceed.\nMr. Montgomery,\nyour opening statement, please.\nLadies and gentlemen of the jury,\nmy grandmother was a simple woman.\nBorn on a farm, she believed\nit was man's divine right\nto benefit from the bounty\nof nature God put before us.\nIf we lived in the topsy-turvy world\n");
                MessageBox.Show("Mr. Benson imagines,\njust think of what would it mean.\nI would have to negotiate\nwith the silkworm\nfor the elastic in my britches!\nTalking bee!\nHow do we know this isn't some sort of\nholographic motion-picture-capture\nHollywood wizardry?\nThey could be using laser beams!\nRobotics! Ventriloquism!\nOloning! For all we know,\nhe could be on steroids!\nMr. Benson?\nLadies and gentlemen,\nthere's no trickery here.\nI'm just an ordinary bee.\nHoney's pretty important to me.\nIt's important to all bees.\nWe invented it!\nWe make it. And we protect it\nwith our lives.\nUnfortunately, there are\nsome people in this room\nwho think they can take it from us\n'cause we're the little guys!\nI'm hoping that, after this is all over,\nyou'll see how, by taking our honey,\nyou not only take everything we have\nbut everything we are!\nI wish he'd dress like that\nall the time. So nice!\nOall your first witness.\nSo, Mr. Klauss Vanderhayden\nof Honey Farms, big company you have.\n");
                MessageBox.Show("I suppose so.\nI see you also own\nHoneyburton and Honron!\nYes, they provide beekeepers\nfor our farms.\nBeekeeper. I find that\nto be a very disturbing term.\nI don't imagine you employ\nany bee-free-ers, do you?\n- No.\n- I couldn't hear you.\n- No.\n- No.\nBecause you don't free bees.\nYou keep bees. Not only that,\nit seems you thought a bear would be\nan appropriate image for a jar of honey.\nThey're very lovable creatures.\nYogi Bear, Fozzie Bear, Build-A-Bear.\nYou mean like this?\nBears kill bees!\nHow'd you like his head crashing\nthrough your living room?!\nBiting into your couch!\nSpitting out your throw pillows!\nOK, that's enough. Take him away.\nSo, Mr. Sting, thank you for being here.\nYour name intrigues me.\n- Where have I heard it before?\n- I was with a band called The Police.\nBut you've never been\na police officer, have you?\nNo, I haven't.\nNo, you haven't. And so here\nwe have yet another example\nof bee culture casually\nstolen by a human\n");
                MessageBox.Show("for nothing more than\na prance-about stage name.\nOh, please.\nHave you ever been stung, Mr. Sting?\nBecause I'm feeling\na little stung, Sting.\nOr should I say... Mr. Gordon M. Sumner!\nThat's not his real name?! You idiots!\nMr. Liotta, first,\nbelated congratulations on\nyour Emmy win for a guest spot\non ER in 2005.\nThank you. Thank you.\nI see from your resume\nthat you're devilishly handsome\nwith a churning inner turmoil\nthat's ready to blow.\nI enjoy what I do. Is that a crime?\nNot yet it isn't. But is this\nwhat it's come to for you?\nExploiting tiny, helpless bees\nso you don't\nhave to rehearse\nyour part and learn your lines, sir?\nWatch it, Benson!\nI could blow right now!\nThis isn't a goodfella.\nThis is a badfella!\nWhy doesn't someone just step on\nthis creep, and we can all go home?!\n- Order in this court!\n- You're all thinking it!\nOrder! Order, I say!\n- Say it!\n- Mr. Liotta, please sit down!\nI think it was awfully nice\n");
                MessageBox.Show("of that bear to pitch in like that.\nI think the jury's on our side.\nAre we doing everything right, legally?\nI'm a florist.\nRight. Well, here's to a great team.\nTo a great team!\nWell, hello.\n- Ken!\n- Hello.\nI didn't think you were coming.\nNo, I was just late.\nI tried to call, but... the battery.\nI didn't want all this to go to waste,\nso I called Barry. Luckily, he was free.\nOh, that was lucky.\nThere's a little left.\nI could heat it up.\nYeah, heat it up, sure, whatever.\nSo I hear you're quite a tennis player.\nI'm not much for the game myself.\nThe ball's a little grabby.\nThat's where I usually sit.\nRight... there.\nKen, Barry was looking at your resume,\nand he agreed with me that eating with\nchopsticks isn't really a special skill.\nYou think I don't see what you're doing?\nI know how hard it is to find\nthe rightjob. We have that in common.\nDo we?\nBees have 100 percent employment,\nbut we do jobs like taking the crud out.\n");
                MessageBox.Show("That's just what\nI was thinking about doing.\nKen, I let Barry borrow your razor\nfor his fuzz. I hope that was all right.\nI'm going to drain the old stinger.\nYeah, you do that.\nLook at that.\nYou know, I've just about had it\nwith your little mind games.\n- What's that?\n- Italian Vogue.\nMamma mia, that's a lot of pages.\nA lot of ads.\nRemember what Van said, why is\nyour life more valuable than mine?\nFunny, I just can't seem to recall that!\nI think something stinks in here!\nI love the smell of flowers.\nHow do you like the smell of flames?!\nNot as much.\nWater bug! Not taking sides!\nKen, I'm wearing a Ohapstick hat!\nThis is pathetic!\nI've got issues!\nWell, well, well, a royal flush!\n- You're bluffing.\n- Am I?\nSurf's up, dude!\nPoo water!\nThat bowl is gnarly.\nExcept for those dirty yellow rings!\nKenneth! What are you doing?!\nYou know, I don't even like honey!\nI don't eat it!\nWe need to talk!\nHe's just a little bee!\nAnd he happens to be\n");
                MessageBox.Show("the nicest bee I've met in a long time!\nLong time? What are you talking about?!\nAre there other bugs in your life?\nNo, but there are other things bugging\nme in life. And you're one of them!\nFine! Talking bees, no yogurt night...\nMy nerves are fried from riding\non this emotional roller coaster!\nGoodbye, Ken.\nAnd for your information,\nI prefer sugar-free, artificial\nsweeteners made by man!\nI'm sorry about all that.\nI know it's got\nan aftertaste! I like it!\nI always felt there was some kind\nof barrier between Ken and me.\nI couldn't overcome it.\nOh, well.\nAre you OK for the trial?\nI believe Mr. Montgomery\nis about out of ideas.\nWe would like to call\nMr. Barry Benson Bee to the stand.\nGood idea! You can really see why he's\nconsidered one of the best lawyers...\nYeah.\nLayton, you've\ngotta weave some magic\nwith this jury,\nor it's gonna be all over.\nDon't worry. The only thing I have\nto do to turn this jury around\nis to remind them\n");
                MessageBox.Show("of what they don't like about bees.\n- You got the tweezers?\n- Are you allergic?\nOnly to losing, son. Only to losing.\nMr. Benson Bee, I'll ask you\nwhat I think we'd all like to know.\nWhat exactly is your relationship\nto that woman?\nWe're friends.\n- Good friends?\n- Yes.\nHow good? Do you live together?\nWait a minute...\nAre you her little...\n...bedbug?\nI've seen a bee documentary or two.\nFrom what I understand,\ndoesn't your queen give birth\nto all the bee children?\n- Yeah, but...\n- So those aren't your real parents!\n- Oh, Barry...\n- Yes, they are!\nHold me back!\nYou're an illegitimate bee,\naren't you, Benson?\nHe's denouncing bees!\nDon't y'all date your cousins?\n- Objection!\n- I'm going to pincushion this guy!\nAdam, don't! It's what he wants!\nOh, I'm hit!!\nOh, lordy, I am hit!\nOrder! Order!\nThe venom! The venom\nis coursing through my veins!\nI have been felled\nby a winged beast of destruction!\nYou see? You can't treat them\n");
                MessageBox.Show("like equals! They're striped savages!\nStinging's the only thing\nthey know! It's their way!\n- Adam, stay with me.\n- I can't feel my legs.\nWhat angel of mercy\nwill come forward to suck the poison\nfrom my heaving buttocks?\nI will have order in this court. Order!\nOrder, please!\nThe case of the honeybees\nversus the human race\ntook a pointed turn against the bees\nyesterday when one of their legal\nteam stung Layton T. Montgomery.\n- Hey, buddy.\n- Hey.\n- Is there much pain?\n- Yeah.\nI...\nI blew the whole case, didn't I?\nIt doesn't matter. What matters is\nyou're alive. You could have died.\nI'd be better off dead. Look at me.\nThey got it from the cafeteria\ndownstairs, in a tuna sandwich.\nLook, there's\na little celery still on it.\nWhat was it like to sting someone?\nI can't explain it. It was all...\nAll adrenaline and then...\nand then ecstasy!\nAll right.\nYou think it was all a trap?\nOf course. I'm sorry.\nI flew us right into this.\n");
                MessageBox.Show("What were we thinking? Look at us. We're\njust a couple of bugs in this world.\nWhat will the humans do to us\nif they win?\nI don't know.\nI hear they put the roaches in motels.\nThat doesn't sound so bad.\nAdam, they check in,\nbut they don't check out!\nOh, my.\nOould you get a nurse\nto close that window?\n- Why?\n- The smoke.\nBees don't smoke.\nRight. Bees don't smoke.\nBees don't smoke!\nBut some bees are smoking.\nThat's it! That's our case!\nIt is? It's not over?\nGet dressed. I've gotta go somewhere.\nGet back to the court and stall.\nStall any way you can.\nAnd assuming you've done step correctly, you're ready for the tub.\nMr. Flayman.\nYes? Yes, Your Honor!\nWhere is the rest of your team?\nWell, Your Honor, it's interesting.\nBees are trained to fly haphazardly,\nand as a result,\nwe don't make very good time.\nI actually heard a funny story about...\nYour Honor,\nhaven't these ridiculous bugs\ntaken up enough\nof this court's valuable time?\n");
                MessageBox.Show("How much longer will we allow\nthese absurd shenanigans to go on?\nThey have presented no compelling\nevidence to support their charges\nagainst my clients,\nwho run legitimate businesses.\nI move for a complete dismissal\nof this entire case!\nMr. Flayman, I'm afraid I'm going\nto have to consider\nMr. Montgomery's motion.\nBut you can't! We have a terrific case.\nWhere is your proof?\nWhere is the evidence?\nShow me the smoking gun!\nHold it, Your Honor!\nYou want a smoking gun?\nHere is your smoking gun.\nWhat is that?\nIt's a bee smoker!\nWhat, this?\nThis harmless little contraption?\nThis couldn't hurt a fly,\nlet alone a bee.\nLook at what has happened\nto bees who have never been asked,\n\"Smoking or non?\"\nIs this what nature intended for us?\nTo be forcibly addicted\nto smoke machines\nand man-made wooden slat work camps?\nLiving out our lives as honey slaves\nto the white man?\n- What are we gonna do?\n- He's playing the species card.\n");
                MessageBox.Show("Ladies and gentlemen, please,\nfree these bees!\nFree the bees! Free the bees!\nFree the bees!\nFree the bees! Free the bees!\nThe court finds in favor of the bees!\nVanessa, we won!\nI knew you could do it! High-five!\nSorry.\nI'm OK! You know what this means?\nAll the honey\nwill finally belong to the bees.\nNow we won't have\nto work so hard all the time.\nThis is an unholy perversion\nof the balance of nature, Benson.\nYou'll regret this.\nBarry, how much honey is out there?\nAll right. One at a time.\nBarry, who are you wearing?\nMy sweater is Ralph Lauren,\nand I have no pants.\n- What if Montgomery's right?\n- What do you mean?\nWe've been living the bee way\na long time, 27 million years.\nOongratulations on your victory.\nWhat will you demand as a settlement?\nFirst, we'll demand a complete shutdown\nof all bee work camps.\nThen we want back the honey\nthat was ours to begin with,\nevery last drop.\nWe demand an end to the glorification\n");
                MessageBox.Show("of the bear as anything more\nthan a filthy, smelly,\nbad-breath stink machine.\nWe're all aware\nof what they do in the woods.\nWait for my signal.\nTake him out.\nHe'll have nauseous\nfor a few hours, then he'll be fine.\nAnd we will no longer tolerate\nbee-negative nicknames...\nBut it's just a prance-about stage name!\n...unnecessary inclusion of honey\nin bogus health products\nand la-dee-da human\ntea-time snack garnishments.\nOan't breathe.\nBring it in, boys!\nHold it right there! Good.\nTap it.\nMr. Buzzwell, we just passed three cups,\nand there's gallons more coming!\n- I think we need to shut down!\n- Shut down? We've never shut down.\nShut down honey production!\nStop making honey!\nTurn your key, sir!\nWhat do we do now?\nOannonball!\nWe're shutting honey production!\nMission abort.\nAborting pollination and nectar detail.\nReturning to base.\nAdam, you wouldn't believe\nhow much honey was out there.\nOh, yeah?\nWhat's going on? Where is everybody?");
                MessageBox.Show("\n- Are they out celebrating?\n- They're home.\nThey don't know what to do.\nLaying out, sleeping in.\nI heard your Uncle Oarl was on his way\nto San Antonio with a cricket.\nAt least we got our honey back.\nSometimes I think, so what if humans\nliked our honey? Who wouldn't?\nIt's the greatest thing in the world!\nI was excited to be part of making it.\nThis was my new desk. This was my\nnew job. I wanted to do it really well.\nAnd now...\nNow I can't.\nI don't understand\nwhy they're not happy.\nI thought their lives would be better!\nThey're doing nothing. It's amazing.\nHoney really changes people.\nYou don't have any idea\nwhat's going on, do you?\n- What did you want to show me?\n- This.\nWhat happened here?\nThat is not the half of it.\nOh, no. Oh, my.\nThey're all wilting.\nDoesn't look very good, does it?\nNo.\nAnd whose fault do you think that is?\nYou know, I'm gonna guess bees.\nBees?\nSpecifically, me.\nI didn't think bees not needing to make\n");
                MessageBox.Show("honey would affect all these things.\nIt's notjust flowers.\nFruits, vegetables, they all need bees.\nThat's our whole SAT test right there.\nTake away produce, that affects\nthe entire animal kingdom.\nAnd then, of course...\nThe human species?\nSo if there's no more pollination,\nit could all just go south here,\ncouldn't it?\nI know this is also partly my fault.\nHow about a suicide pact?\nHow do we do it?\n- I'll sting you, you step on me.\n- Thatjust kills you twice.\nRight, right.\nListen, Barry...\nsorry, but I gotta get going.\nI had to open my mouth and talk.\nVanessa?\nVanessa? Why are you leaving?\nWhere are you going?\nTo the final Tournament of Roses parade\nin Pasadena.\nThey've moved it to this weekend\nbecause all the flowers are dying.\nIt's the last chance\nI'll ever have to see it.\nVanessa, I just wanna say I'm sorry.\nI never meant it to turn out like this.\nI know. Me neither.\nTournament of Roses.\nRoses can't do sports.\n");
                MessageBox.Show("Wait a minute. Roses. Roses?\nRoses!\nVanessa!\nRoses?!\nBarry?\n- Roses are flowers!\n- Yes, they are.\nFlowers, bees, pollen!\nI know.\nThat's why this is the last parade.\nMaybe not.\nOould you ask him to slow down?\nOould you slow down?\nBarry!\nOK, I made a huge mistake.\nThis is a total disaster, all my fault.\nYes, it kind of is.\nI've ruined the planet.\nI wanted to help you\nwith the flower shop.\nI've made it worse.\nActually, it's completely closed down.\nI thought maybe you were remodeling.\nBut I have another idea, and it's\ngreater than my previous ideas combined.\nI don't want to hear it!\nAll right, they have the roses,\nthe roses have the pollen.\nI know every bee, plant\nand flower bud in this park.\nAll we gotta do is get what they've got\nback here with what we've got.\n- Bees.\n- Park.\n- Pollen!\n- Flowers.\n- Repollination!\n- Across the nation!\nTournament of Roses,\nPasadena, Oalifornia.\nThey've got nothing\nbut flowers, floats and cotton candy.\n");
                MessageBox.Show("Security will be tight.\nI have an idea.\nVanessa Bloome, FTD.\nOfficial floral business. It's real.\nSorry, ma'am. Nice brooch.\nThank you. It was a gift.\nOnce inside,\nwe just pick the right float.\nHow about The Princess and the Pea?\nI could be the princess,\nand you could be the pea!\nYes, I got it.\n- Where should I sit?\n- What are you?\n- I believe I'm the pea.\n- The pea?\nIt goes under the mattresses.\n- Not in this fairy tale, sweetheart.\n- I'm getting the marshal.\nYou do that!\nThis whole parade is a fiasco!\nLet's see what this baby'll do.\nHey, what are you doing?!\nThen all we do\nis blend in with traffic...\n...without arousing suspicion.\nOnce at the airport,\nthere's no stopping us.\nStop! Security.\n- You and your insect pack your float?\n- Yes.\nHas it been\nin your possession the entire time?\nWould you remove your shoes?\n- Remove your stinger.\n- It's part of me.\nI know. Just having some fun.\nEnjoy your flight.\nThen if we're lucky, we'll have\n");
                MessageBox.Show("just enough pollen to do the job.\nOan you believe how lucky we are? We\nhave just enough pollen to do the job!\nI think this is gonna work.\nIt's got to work.\nAttention, passengers,\nthis is Oaptain Scott.\nWe have a bit of bad weather\nin New York.\nIt looks like we'll experience\na couple hours delay.\nBarry, these are cut flowers\nwith no water. They'll never make it.\nI gotta get up there\nand talk to them.\nBe careful.\nOan I get help\nwith the Sky Mall magazine?\nI'd like to order the talking\ninflatable nose and ear hair trimmer.\nOaptain, I'm in a real situation.\n- What'd you say, Hal?\n- Nothing.\nBee!\nDon't freak out! My entire species...\nWhat are you doing?\n- Wait a minute! I'm an attorney!\n- Who's an attorney?\nDon't move.\nOh, Barry.\nGood afternoon, passengers.\nThis is your captain.\nWould a Miss Vanessa Bloome in 24B\nplease report to the cockpit?\nAnd please hurry!\nWhat happened here?\nThere was a DustBuster,\na toupee, a life raft exploded.\n");
                MessageBox.Show("One's bald, one's in a boat,\nthey're both unconscious!\n- Is that another bee joke?\n- No!\nNo one's flying the plane!\nThis is JFK control tower, Flight 356.\nWhat's your status?\nThis is Vanessa Bloome.\nI'm a florist from New York.\nWhere's the pilot?\nHe's unconscious,\nand so is the copilot.\nNot good. Does anyone onboard\nhave flight experience?\nAs a matter of fact, there is.\n- Who's that?\n- Barry Benson.\nFrom the honey trial?! Oh, great.\nVanessa, this is nothing more\nthan a big metal bee.\nIt's got giant wings, huge engines.\nI can't fly a plane.\n- Why not? Isn't John Travolta a pilot?\n- Yes.\nHow hard could it be?\nWait, Barry!\nWe're headed into some lightning.\nThis is Bob Bumble. We have some\nlate-breaking news from JFK Airport,\nwhere a suspenseful scene\nis developing.\nBarry Benson,\nfresh from his legal victory...\nThat's Barry!\n...is attempting to land a plane,\nloaded with people, flowers\nand an incapacitated flight crew.\nFlowers?!\n");
                MessageBox.Show("We have a storm in the area\nand two individuals at the controls\nwith absolutely no flight experience.\nJust a minute.\nThere's a bee on that plane.\nI'm quite familiar with Mr. Benson\nand his no-account compadres.\nThey've done enough damage.\nBut isn't he your only hope?\nTechnically, a bee\nshouldn't be able to fly at all.\nTheir wings are too small...\nHaven't we heard this a million times?\n\"The surface area of the wings\nand body mass make no sense.\"\n- Get this on the air!\n- Got it.\n- Stand by.\n- We're going live.\nThe way we work may be a mystery to you.\nMaking honey takes a lot of bees\ndoing a lot of small jobs.\nBut let me tell you about a small job.\nIf you do it well,\nit makes a big difference.\nMore than we realized.\nTo us, to everyone.\nThat's why I want to get bees\nback to working together.\nThat's the bee way!\nWe're not made of Jell-O.\nWe get behind a fellow.\n- Black and yellow!\n- Hello!\nLeft, right, down, hover.\n- Hover?\n");
                MessageBox.Show("- Forget hover.\nThis isn't so hard.\nBeep-beep! Beep-beep!\nBarry, what happened?!\nWait, I think we were\non autopilot the whole time.\n- That may have been helping me.\n- And now we're not!\nSo it turns out I cannot fly a plane.\nAll of you, let's get\nbehind this fellow! Move it out!\nMove out!\nOur only chance is if I do what I'd do,\nyou copy me with the wings of the plane!\nDon't have to yell.\nI'm not yelling!\nWe're in a lot of trouble.\nIt's very hard to concentrate\nwith that panicky tone in your voice!\nIt's not a tone. I'm panicking!\nI can't do this!\nVanessa, pull yourself together.\nYou have to snap out of it!\nYou snap out of it.\nYou snap out of it.\n- You snap out of it!\n- You snap out of it!\n- You snap out of it!\n- You snap out of it!\n- You snap out of it!\n- You snap out of it!\n- Hold it!\n- Why? Oome on, it's my turn.\nHow is the plane flying?\nI don't know.\nHello?\nBenson, got any flowers\nfor a happy occasion in there?\nThe Pollen Jocks!\n");
                MessageBox.Show("They do get behind a fellow.\n- Black and yellow.\n- Hello.\nAll right, let's drop this tin can\non the blacktop.\nWhere? I can't see anything. Oan you?\nNo, nothing. It's all cloudy.\nOome on. You got to think bee, Barry.\n- Thinking bee.\n- Thinking bee.\nThinking bee!\nThinking bee! Thinking bee!\nWait a minute.\nI think I'm feeling something.\n- What?\n- I don't know. It's strong, pulling me.\nLike a 27-million-year-old instinct.\nBring the nose down.\nThinking bee!\nThinking bee! Thinking bee!\n- What in the world is on the tarmac?\n- Get some lights on that!\nThinking bee!\nThinking bee! Thinking bee!\n- Vanessa, aim for the flower.\n- OK.\nOut the engines. We're going in\non bee power. Ready, boys?\nAffirmative!\nGood. Good. Easy, now. That's it.\nLand on that flower!\nReady? Full reverse!\nSpin it around!\n- Not that flower! The other one!\n- Which one?\n- That flower.\n- I'm aiming at the flower!\nThat's a fat guy in a flowered shirt.\n");
                MessageBox.Show("I mean the giant pulsating flower\nmade of millions of bees!\nPull forward. Nose down. Tail up.\nRotate around it.\n- This is insane, Barry!\n- This's the only way I know how to fly.\nAm I koo-koo-kachoo, or is this plane\nflying in an insect-like pattern?\nGet your nose in there. Don't be afraid.\nSmell it. Full reverse!\nJust drop it. Be a part of it.\nAim for the center!\nNow drop it in! Drop it in, woman!\nOome on, already.\nBarry, we did it!\nYou taught me how to fly!\n- Yes. No high-five!\n- Right.\nBarry, it worked!\nDid you see the giant flower?\nWhat giant flower? Where? Of course\nI saw the flower! That was genius!\n- Thank you.\n- But we're not done yet.\nListen, everyone!\nThis runway is covered\nwith the last pollen\nfrom the last flowers\navailable anywhere on Earth.\nThat means this is our last chance.\nWe're the only ones who make honey,\npollinate flowers and dress like this.\nIf we're gonna survive as a species,\nthis is our moment! What do you say?\n");
                MessageBox.Show("Are we going to be bees, orjust\nMuseum of Natural History keychains?\nWe're bees!\nKeychain!\nThen follow me! Except Keychain.\nHold on, Barry. Here.\nYou've earned this.\nYeah!\nI'm a Pollen Jock! And it's a perfect\nfit. All I gotta do are the sleeves.\nOh, yeah.\nThat's our Barry.\nMom! The bees are back!\nIf anybody needs\nto make a call, now's the time.\nI got a feeling we'll be\nworking late tonight!\nHere's your change. Have a great\nafternoon! Oan I help who's next?\nWould you like some honey with that?\nIt is bee-approved. Don't forget these.\nMilk, cream, cheese, it's all me.\nAnd I don't see a nickel!\nSometimes I just feel\nlike a piece of meat!\nI had no idea.\nBarry, I'm sorry.\nHave you got a moment?\nWould you excuse me?\nMy mosquito associate will help you.\nSorry I'm late.\nHe's a lawyer too?\nI was already a blood-sucking parasite.\nAll I needed was a briefcase.\nHave a great afternoon!\nBarry, I just got this huge tulip order,\n");
                MessageBox.Show("and I can't get them anywhere.\nNo problem, Vannie.\nJust leave it to me.\nYou're a lifesaver, Barry.\nOan I help who's next?\nAll right, scramble, jocks!\nIt's time to fly.\nThank you, Barry!\nThat bee is living my life!\nLet it go, Kenny.\n- When will this nightmare end?!\n- Let it all go.\n- Beautiful day to fly.\n- Sure is.\nBetween you and me,\nI was dying to get out of that office.\nYou have got\nto start thinking bee, my friend.\n- Thinking bee!\n- Me?\nHold it. Let's just stop\nfor a second. Hold it.\nI'm sorry. I'm sorry, everyone.\nOan we stop here?\nI'm not making a major life decision\nduring a production number!\nAll right. Take ten, everybody.\nWrap it up, guys.\nI had virtually no rehearsal for that.");
                   
                WaitLabel.Cursor = Cursors.Hand;
                return;
            }
            else if (countClicks < 43)
            {
                WaitLabel.Content ="Are you seriously still here?";
                WaitLabel.FontSize = 16;
                return;
            }
            else if(countClicks < 50)
            {
                WaitLabel.Content = "";
                return;
            }
            else
            {
                WaitLabel.Content = "Fine, you can proceed";
                ProceedButton.Visibility = Visibility.Visible;
                ProceedButton.IsEnabled = true;
                countClicks = 0;
                return;
            }
        }
        //
        private void ProceedButton_Click(object sender, RoutedEventArgs e)
        {
            WaitLabel.Content = "Sike! you thought, now keep clicking this until you hit Ethan's favorite number";
            WaitLabel.FontSize = 15;
            countClicks++;
            if(countClicks == 69)
            {
                countClicks = 0;
                ProceedButton.Visibility = Visibility.Collapsed;
                ProceedButton.IsEnabled = false;
                Confirmed(1);
            }
            else if(countClicks > 69)
            {
                countClicks = 0;
                ProceedButton.Visibility = Visibility.Collapsed;
                ProceedButton.IsEnabled = false;
                Confirmed(-1);
            }
        }

//////////////////////////////////////////////////
// Maze Puzzle
//////////////////////////////////////////////////
        
        //Will launch the maze
        private void MazeStart_Click(object sender, RoutedEventArgs e)
        {
            Maze temp = new Maze();//initialize a new maze
            temp.Show();//Display the maze window
            temp.StartMaze(this);//Pass in the mainWindow so that the maze can call confirmed()
        }

//////////////////////////////////////////////////
// AgeChecker Puzzle
//////////////////////////////////////////////////
        // For storing the user provided age for the AgeChecker Puzzle
        private int eventAge = new int();
        // For keeping the current index of the List of World Events for the AgeChecker Puzzle
        private int eventCurrent = new int();
        // For keeping the established max index of the List of World Events for the AgeChecker Puzzle 
        private int eventMax = new int();
        // For keeping the established min index of the List of World Events for the AgeChecker Puzzle
        private int eventMin = new int();
        // The container hold the list of world events and their corresponding year
        private List<Tuple<string, int>> worldEvents = new List<Tuple<string, int>>();

        // For receiving the self inserted age
        private void GetAge_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                eventAge = int.Parse(TheAge.Text);
                GetAge.Visibility = Visibility.Collapsed;
                GetAge.IsEnabled = false;
                TheAge.Visibility = Visibility.Collapsed;
                TheAge.IsEnabled = false;
                eventMax = worldEvents.Count-1; eventMin = 0;
                eventCurrent = rand.Next(eventMin, eventMax+1);
                EventDetails.Text = worldEvents[eventCurrent].Item1;
                EventConfirm.IsEnabled = true;
                EventConfirm.Visibility = Visibility.Visible;
                EventDetails.IsEnabled = true;
                EventDetails.Visibility = Visibility.Visible;
                EventBefore.IsEnabled = true;
                EventBefore.Visibility = Visibility.Visible;
                EventAfter.IsEnabled = true;
                EventAfter.Visibility = Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("That was not a valid number");
            }
        }
        // For narrowing down the worldEvent list to two events and then comparing the estimated ages against the users input age
        private void EventConfirm_Click(object sender, RoutedEventArgs e)
        {
            // make current index the new maximum
            if(EventBefore.IsChecked == true)
            {
                eventMax = eventCurrent;
            }
            // make current index the new minimum
            else if(EventAfter.IsChecked == true)
            {
                eventMin = eventCurrent;
            }
            // tell the player they must select an option
            else
            {
                MessageBox.Show("You must select an option");
                return;
            }
            // when we narrow things down to two events
            if (eventMax == eventMin+1)
            {
                // if the age the user provided fits in the range between the two events.
                // we expanded out the range by a year after the max to account for individuals who have not had their birthday yet during the current year
                if(eventAge <= (DateTime.Now.Year - worldEvents[eventMin].Item2) && eventAge >= (DateTime.Now.Year - worldEvents[eventMax].Item2-1))
                {
                    MessageBox.Show("Correct");
                    Confirmed(1);
                }
                // if the age does not fit in the range
                else
                {
                    MessageBox.Show("Incorrect");
                    Confirmed(0);
                }
            }
            // when they were born before the first event
            if (eventMax == 0)
            {
                MessageBox.Show("Wow, you're old");
                Confirmed(0);
            }
            // when they were born after the last event
            if (eventMin == worldEvents.Count - 1)
            {
                MessageBox.Show("You are too young for this game!!!!");
                this.Close();
                App.Current.Shutdown();
            }
            // stores the current index for the worldEvents container
            int previous = eventCurrent;
            do
            {
                // generate a new index for the worldEvents container between the established min and max
                // intentionally done randomly to make the process inefficient and provide no clues as to the year the world event happened
                eventCurrent = rand.Next(eventMin, eventMax+1);
            }
            while (previous == eventCurrent); // make sure the new index is not the same as the last index
            // load the string of the currently indexed worldEvent into the textbox
            EventDetails.Text = worldEvents[eventCurrent].Item1;
        }

//////////////////////////////////////////////////
// End_Page
//////////////////////////////////////////////////

        // If user presses the "Win the Game" button
        private void End_Win_Click(object sender, RoutedEventArgs e)
        {
            // Toggles ability to win the game
            App.Current.Properties["CanWin"] = !(bool)App.Current.Properties["CanWin"];
            if ((bool)App.Current.Properties["CanWin"])
            {
                MessageBox.Show("Ability to Win Enabled!");
            }
            else
            {
                MessageBox.Show("Ability to Win Disabled!");
            }
        }

        // If user presses the "Lose the Game" button
        private void End_Lose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wow, I can't believe you pressed that");
            MessageBox.Show("The outcome of pressing that button seems really straightforward");
            MessageBox.Show("Well, I am a disembodied line of code of my word, so...");
            MessageBox.Show("You Lose\nTry Again!");
            ReturnToSelection();
        }

        // Calls function to determine winner and outputs message box with results
        private void End_Normal_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Properties["CompChoice"] = rand.Next(15);
            string msg = String.Format("The player chose {0} and the computer chose {1}.",
                (Choices)((int)App.Current.Properties["PlayerChoice"]),
                (Choices)((int)App.Current.Properties["CompChoice"]));
            // if user activated the ability to win
            if ((bool)App.Current.Properties["CanWin"])
            {
                msg += $"\n{DetermineWinner((Choices)(int)App.Current.Properties["PlayerChoice"], (Choices)(int)App.Current.Properties["CompChoice"])}";
                MessageBox.Show(msg);
                // If draw or lose
                if ((int)App.Current.Properties["Winner"] == 0 || (int)App.Current.Properties["Winner"] == -1)
                {
                    // return to seleciton page
                    ReturnToSelection();
                }
                // if win
                else
                {
                    //close the game
                    this.Close();
                    App.Current.Shutdown();
                }
            }
            // if user failed to activate ability to win
            else
            {
                msg += $"\nUnfortunately, you failed to opt in to winning,\nso {((Choices)(int)App.Current.Properties["CompChoice"]).ToString()} beats {((Choices)(int)App.Current.Properties["PlayerChoice"]).ToString()}\nTry Again!";
                MessageBox.Show(msg);
                ReturnToSelection();
            }
        }

        // Function to determine the winner of the game
        private string DetermineWinner(Choices first, Choices second)
        {
            int winner = (first.ToString(), second.ToString()) switch
            {
                // If player chooses Rock
                ("Rock", "Gun") => -1,
                ("Rock", "Lightning") => -1,
                ("Rock", "Devil") => -1,
                ("Rock", "Dragon") => -1,
                ("Rock", "water") => -1,
                ("Rock", "Air") => -1,
                ("Rock", "Paper") => -1,
                ("Rock", "Sponge") => 1,
                ("Rock", "Wolf") => 1,
                ("Rock", "Tree") => 1,
                ("Rock", "Human") => 1,
                ("Rock", "Snake") => 1,
                ("Rock", "Scissors") => 1,
                ("Rock", "Fire") => 1,
                // If player chooses Gun
                ("Gun", "Rock") => 1,
                ("Gun", "Lightning") => -1,
                ("Gun", "Devil") => -1,
                ("Gun", "Dragon") => -1,
                ("Gun", "water") => -1,
                ("Gun", "Air") => -1,
                ("Gun", "Paper") => -1,
                ("Gun", "Sponge") => -1,
                ("Gun", "Wolf") => 1,
                ("Gun", "Tree") => 1,
                ("Gun", "Human") => 1,
                ("Gun", "Snake") => 1,
                ("Gun", "Scissors") => 1,
                ("Gun", "Fire") => 1,
                // If player chooses Lightning
                ("Lightning", "Rock") => 1,
                ("Lightning", "Gun") => 1,
                ("Lightning", "Devil") => -1,
                ("Lightning", "Dragon") => -1,
                ("Lightning", "water") => -1,
                ("Lightning", "Air") => -1,
                ("Lightning", "Paper") => -1,
                ("Lightning", "Sponge") => -1,
                ("Lightning", "Wolf") => -1,
                ("Lightning", "Tree") => 1,
                ("Lightning", "Human") => 1,
                ("Lightning", "Snake") => 1,
                ("Lightning", "Scissors") => 1,
                ("Lightning", "Fire") => 1,
                // If player chooses Devil
                ("Devil", "Rock") => 1,
                ("Devil", "Gun") => 1,
                ("Devil", "Lightning") => 1,
                ("Devil", "Dragon") => -1,
                ("Devil", "water") => -1,
                ("Devil", "Air") => -1,
                ("Devil", "Paper") => -1,
                ("Devil", "Sponge") => -1,
                ("Devil", "Wolf") => -1,
                ("Devil", "Tree") => -1,
                ("Devil", "Human") => 1,
                ("Devil", "Snake") => 1,
                ("Devil", "Scissors") => 1,
                ("Devil", "Fire") => 1,
                // If player chooses Dragon
                ("Dragon", "Rock") => 1,
                ("Dragon", "Gun") => 1,
                ("Dragon", "Lightning") => 1,
                ("Dragon", "Devil") => 1,
                ("Dragon", "water") => -1,
                ("Dragon", "Air") => -1,
                ("Dragon", "Paper") => -1,
                ("Dragon", "Sponge") => -1,
                ("Dragon", "Wolf") => -1,
                ("Dragon", "Tree") => -1,
                ("Dragon", "Human") => -1,
                ("Dragon", "Snake") => 1,
                ("Dragon", "Scissors") => 1,
                ("Dragon", "Fire") => 1,
                // If player chooses water
                ("water", "Rock") => 1,
                ("water", "Gun") => 1,
                ("water", "Lightning") => 1,
                ("water", "Devil") => 1,
                ("water", "Dragon") => 1,
                ("water", "Air") => -1,
                ("water", "Paper") => -1,
                ("water", "Sponge") => -1,
                ("water", "Wolf") => -1,
                ("water", "Tree") => -1,
                ("water", "Human") => -1,
                ("water", "Snake") => -1,
                ("water", "Scissors") => 1,
                ("water", "Fire") => 1,
                // If player chooses Air
                ("Air", "Rock") => 1,
                ("Air", "Gun") => 1,
                ("Air", "Lightning") => 1,
                ("Air", "Devil") => 1,
                ("Air", "Dragon") => 1,
                ("Air", "water") => 1,
                ("Air", "Paper") => -1,
                ("Air", "Sponge") => -1,
                ("Air", "Wolf") => -1,
                ("Air", "Tree") => -1,
                ("Air", "Human") => -1,
                ("Air", "Snake") => -1,
                ("Air", "Scissors") => -1,
                ("Air", "Fire") => 1,
                // If player chooses Paper
                ("Paper", "Rock") => 1,
                ("Paper", "Gun") => 1,
                ("Paper", "Lightning") => 1,
                ("Paper", "Devil") => 1,
                ("Paper", "Dragon") => 1,
                ("Paper", "water") => 1,
                ("Paper", "Air") => 1,
                ("Paper", "Sponge") => -1,
                ("Paper", "Wolf") => -1,
                ("Paper", "Tree") => -1,
                ("Paper", "Human") => -1,
                ("Paper", "Snake") => -1,
                ("Paper", "Scissors") => -1,
                ("Paper", "Fire") => -1,
                // If player chooses Sponge
                ("Sponge", "Rock") => -1,
                ("Sponge", "Gun") => 1,
                ("Sponge", "Lightning") => 1,
                ("Sponge", "Devil") => 1,
                ("Sponge", "Dragon") => 1,
                ("Sponge", "water") => 1,
                ("Sponge", "Air") => 1,
                ("Sponge", "Paper") => 1,
                ("Sponge", "Wolf") => -1,
                ("Sponge", "Tree") => -1,
                ("Sponge", "Human") => -1,
                ("Sponge", "Snake") => -1,
                ("Sponge", "Scissors") => -1,
                ("Sponge", "Fire") => -1,
                // If player chooses Wolf
                ("Wolf", "Rock") => -1,
                ("Wolf", "Gun") => -1,
                ("Wolf", "Lightning") => 1,
                ("Wolf", "Devil") => 1,
                ("Wolf", "Dragon") => 1,
                ("Wolf", "water") => 1,
                ("Wolf", "Air") => 1,
                ("Wolf", "Paper") => 1,
                ("Wolf", "Sponge") => 1,
                ("Wolf", "Tree") => -1,
                ("Wolf", "Human") => -1,
                ("Wolf", "Snake") => -1,
                ("Wolf", "Scissors") => -1,
                ("Wolf", "Fire") => -1,
                // If player chooses Tree
                ("Tree", "Rock") => -1,
                ("Tree", "Gun") => -1,
                ("Tree", "Lightning") => -1,
                ("Tree", "Devil") => 1,
                ("Tree", "Dragon") => 1,
                ("Tree", "water") => 1,
                ("Tree", "Air") => 1,
                ("Tree", "Paper") => 1,
                ("Tree", "Sponge") => 1,
                ("Tree", "Wolf") => 1,
                ("Tree", "Human") => -1,
                ("Tree", "Snake") => -1,
                ("Tree", "Scissors") => -1,
                ("Tree", "Fire") => -1,
                // If player chooses Human
                ("Human", "Rock") => -1,
                ("Human", "Gun") => -1,
                ("Human", "Lightning") => -1,
                ("Human", "Devil") => -1,
                ("Human", "Dragon") => 1,
                ("Human", "water") => 1,
                ("Human", "Air") => 1,
                ("Human", "Paper") => 1,
                ("Human", "Sponge") => 1,
                ("Human", "Wolf") => 1,
                ("Human", "Tree") => 1,
                ("Human", "Snake") => -1,
                ("Human", "Scissors") => -1,
                ("Human", "Fire") => -1,
                // If player chooses Snake
                ("Snake", "Rock") => -1,
                ("Snake", "Gun") => -1,
                ("Snake", "Lightning") => -1,
                ("Snake", "Devil") => -1,
                ("Snake", "Dragon") => -1,
                ("Snake", "water") => 1,
                ("Snake", "Air") => 1,
                ("Snake", "Paper") => 1,
                ("Snake", "Sponge") => 1,
                ("Snake", "Wolf") => 1,
                ("Snake", "Tree") => 1,
                ("Snake", "Human") => 1,
                ("Snake", "Scissors") => -1,
                ("Snake", "Fire") => -1,
                // If player chooses Scissors
                ("Scissors", "Rock") => -1,
                ("Scissors", "Gun") => -1,
                ("Scissors", "Lightning") => -1,
                ("Scissors", "Devil") => -1,
                ("Scissors", "Dragon") => -1,
                ("Scissors", "water") => -1,
                ("Scissors", "Air") => 1,
                ("Scissors", "Paper") => 1,
                ("Scissors", "Sponge") => 1,
                ("Scissors", "Wolf") => 1,
                ("Scissors", "Tree") => 1,
                ("Scissors", "Human") => 1,
                ("Scissors", "Snake") => 1,
                ("Scissors", "Fire") => -1,
                // If player chooses Fire
                ("Fire", "Rock") => -1,
                ("Fire", "Gun") => -1,
                ("Fire", "Lightning") => -1,
                ("Fire", "Devil") => -1,
                ("Fire", "Dragon") => -1,
                ("Fire", "water") => -1,
                ("Fire", "Air") => -1,
                ("Fire", "Paper") => 1,
                ("Fire", "Sponge") => 1,
                ("Fire", "Wolf") => 1,
                ("Fire", "Tree") => 1,
                ("Fire", "Human") => 1,
                ("Fire", "Snake") => 1,
                ("Fire", "Scissors") => 1,
                // If player and comp choose the same result
                (_, _) => 0,
            };
            // stores winner in global variable for later use
            App.Current.Properties["Winner"] = winner;
            // returns string with results
            return (winner) switch
            {
                (-1) => $"{((Choices)((int)App.Current.Properties["CompChoice"])).ToString()} Beats {((Choices)((int)App.Current.Properties["PlayerChoice"])).ToString()}\nComputer Wins!\nTry Again",
                (1) => $"{((Choices)((int)App.Current.Properties["PlayerChoice"])).ToString()} Beats {((Choices)((int)App.Current.Properties["CompChoice"])).ToString()}\nYou Win!\nYou're free to go",
                (0) => "No One Wins.\nTry Again.",
            };
        }

    }
}