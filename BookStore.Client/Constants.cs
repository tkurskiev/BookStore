namespace BookStore.Client
{
    public static class Constants
    {
        public static List<Book> Books = new()
        {
            //new Book() {Title = "", Author = "", PublicationDate = ""},

            new Book {Title = "The Tale of Peter Rabbit", Author = "Beatrix Potter", PublicationDate = "1902"},
            new Book {Title = "Jonathan Livingston Seagull", Author = "Richard Bach", PublicationDate = "1970"},
            new Book {Title = "The Very Hungry Caterpillar", Author = "Eric Carle", PublicationDate = "1969"},
            new Book {Title = "A Message to Garcia", Author = "Elbert Hubbard", PublicationDate = "1899"},
            new Book {Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationDate = "1960"},
            new Book {Title = "Flowers in the Attic", Author = "V. C. Andrews", PublicationDate = "1979"},
            new Book {Title = "Cosmos", Author = "Carl Sagan", PublicationDate = "1980"},
            new Book {Title = "Sophie's World (Sofies verden)", Author = "Jostein Gaarder", PublicationDate = "1991"},
            new Book {Title = "Angels & Demons", Author = "Dan Brown", PublicationDate = "2000"},
            new Book {Title = "Kane and Abel", Author = "Jeffrey Archer", PublicationDate = "1979"},
            new Book
            {
                Title = "How the Steel Was Tempered (Как закалялась сталь)", Author = "Nikolai Ostrovsky",
                PublicationDate = "1932"
            },
            new Book {Title = "War and Peace (Война и мир)", Author = "Leo Tolstoy", PublicationDate = "1869"},
            new Book
            {
                Title = "The Adventures of Pinocchio (Le avventure di Pinocchio)", Author = "Carlo Collodi",
                PublicationDate = "1881"
            },
            new Book
            {
                Title = "The Diary of Anne Frank (Het Achterhuis)", Author = "Anne Frank", PublicationDate = "1947"
            },
            new Book {Title = "Your Erroneous Zones", Author = "Wayne Dyer", PublicationDate = "1976"},
            new Book {Title = "The Thorn Birds", Author = "Colleen McCullough", PublicationDate = "1977"},
            new Book {Title = "The Purpose Driven Life", Author = "Rick Warren", PublicationDate = "2002"},
            new Book {Title = "The Kite Runner", Author = "Khaled Hosseini", PublicationDate = "2003"},
            new Book {Title = "Valley of the Dolls", Author = "Jacqueline Susann", PublicationDate = "1966"},
            new Book {Title = "Alcoholics Anonymous Big Book", Author = "Bill Wilson", PublicationDate = "1939"},
            new Book
            {
                Title = "How to Win Friends and Influence People", Author = "Dale Carnegie", PublicationDate = "1936"
            },
            new Book {Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationDate = "1925"},
            new Book {Title = "Gone with the Wind", Author = "Margaret Mitchell", PublicationDate = "1936"},
            new Book {Title = "Rebecca", Author = "Daphne du Maurier", PublicationDate = "1938"},
            new Book {Title = "Nineteen Eighty-Four", Author = "George Orwell", PublicationDate = "1949"},
            new Book {Title = "The Revolt of Mamie Stover", Author = "William Bradford Huie", PublicationDate = "1951"},
            new Book
            {
                Title = "The Girl with the Dragon Tattoo (Män som hatar kvinnor)", Author = "Stieg Larsson",
                PublicationDate = "2005"
            },
            new Book {Title = "The Lost Symbol", Author = "Dan Brown", PublicationDate = "2009"},
            new Book {Title = "The Hunger Games", Author = "Suzanne Collins", PublicationDate = "2008"},
            new Book {Title = "James and the Giant Peach", Author = "Roald Dahl", PublicationDate = "1961"},
            new Book
            {
                Title = "The Young Guard (Молодая гвардия)", Author = "Alexander Alexandrovich Fadeyev",
                PublicationDate = "1945"
            },
            new Book {Title = "Who Moved My Cheese?", Author = "Spencer Johnson", PublicationDate = "1998"},
            new Book {Title = "A Brief History of Time", Author = "Stephen Hawking", PublicationDate = "1988"},
            new Book
            {
                Title = "Paul et Virginie", Author = "Jacques-Henri Bernardin de Saint-Pierre", PublicationDate = "1788"
            },
            new Book {Title = "Lust for Life", Author = "Irving Stone", PublicationDate = "1934"},
            new Book {Title = "The Wind in the Willows", Author = "Kenneth Grahame", PublicationDate = "1908"},
            new Book
            {
                Title = "The 7 Habits of Highly Effective People", Author = "Stephen R. Covey", PublicationDate = "1989"
            },
            new Book
            {
                Title = "Virgin Soil Upturned (Поднятая целина)", Author = "Mikhail Sholokhov", PublicationDate = "1935"
            },
            new Book {Title = "The Celestine Prophecy", Author = "James Redfield", PublicationDate = "1993"},
            new Book {Title = "The Fault in Our Stars", Author = "John Green", PublicationDate = "2012"},
            new Book {Title = "The Girl on the Train", Author = "Paula Hawkins", PublicationDate = "2015"},
            new Book {Title = "The Shack", Author = "William P. Young", PublicationDate = "2007"},
            new Book {Title = "Uncle Styopa (Дядя Стёпа)", Author = "Sergey Mikhalkov", PublicationDate = "1936"},
            new Book {Title = "The Godfather", Author = "Mario Puzo", PublicationDate = "1969"},
            new Book {Title = "Love Story", Author = "Erich Segal", PublicationDate = "1970"},
            new Book {Title = "Catching Fire", Author = "Suzanne Collins", PublicationDate = "2009"},
            new Book {Title = "Mockingjay", Author = "Suzanne Collins", PublicationDate = "2010"},
            new Book {Title = "Kitchen", Author = "Banana Yoshimoto", PublicationDate = "1988"},
            new Book {Title = "Andromeda Nebula", Author = "Ivan Yefremov", PublicationDate = "1957"},
            new Book {Title = "Autobiography of a Yogi", Author = "Paramahansa Yogananda", PublicationDate = "1946"},
            new Book {Title = "Gone Girl", Author = "Gillian Flynn", PublicationDate = "2012"},
            new Book
            {
                Title = "All Quiet on the Western Front (Im Westen nichts Neues)", Author = "Erich Maria Remarque",
                PublicationDate = "1929"
            },
            new Book {Title = "The Bermuda Triangle", Author = "Charles Berlitz", PublicationDate = "1974"},
            new Book {Title = "Things Fall Apart", Author = "Chinua Achebe", PublicationDate = "1958"},
            new Book {Title = "Animal Farm", Author = "George Orwell", PublicationDate = "1945"},
            new Book {Title = "Wolf Totem (狼图腾)", Author = "Jiang Rong", PublicationDate = "2004"},
            new Book {Title = "The Happy Hooker: My Own Story", Author = "Xaviera Hollander", PublicationDate = "1971"},
            new Book {Title = "Jaws", Author = "Peter Benchley", PublicationDate = "1974"},
            new Book {Title = "Love You Forever", Author = "Robert Munsch", PublicationDate = "1986"},
            new Book {Title = "The Women's Room", Author = "Marilyn French", PublicationDate = "1977"},
            new Book
            {
                Title = "What to Expect When You're Expecting", Author = "Arlene Eisenberg and Heidi Murkoff",
                PublicationDate = "1984"
            },
            new Book {Title = "Adventures of Huckleberry Finn", Author = "Mark Twain", PublicationDate = "1885"},
            new Book
            {
                Title = "The Secret Diary of Adrian Mole, Aged 13¾", Author = "Sue Townsend", PublicationDate = "1982"
            },
            new Book {Title = "Pride and Prejudice", Author = "Jane Austen", PublicationDate = "1813"},
            new Book
            {
                Title = "Kon-Tiki: Across the Pacific in a Raft (Kon-Tiki ekspedisjonen)", Author = "Thor Heyerdahl",
                PublicationDate = "1950"
            },
            new Book
            {
                Title = "The Good Soldier Švejk (Osudy dobrého vojáka Švejka za světové války)",
                Author = "Jaroslav Hašek", PublicationDate = "1923"
            },
            new Book {Title = "Where the Wild Things Are", Author = "Maurice Sendak", PublicationDate = "1963"},
            new Book
            {
                Title = "The Power of Positive Thinking", Author = "Norman Vincent Peale", PublicationDate = "1952"
            },
            new Book {Title = "The Secret", Author = "Rhonda Byrne", PublicationDate = "2006"},
            new Book {Title = "Fear of Flying", Author = "Erica Jong", PublicationDate = "1973"},
            new Book {Title = "Dune", Author = "Frank Herbert", PublicationDate = "1965"},
            new Book {Title = "Charlie and the Chocolate Factory", Author = "Roald Dahl", PublicationDate = "1964"},
            new Book {Title = "The Naked Ape", Author = "Desmond Morris", PublicationDate = "1968"},
            new Book
            {
                Title = "Totto-chan, the Little Girl at the Window (窓ぎわのトットちゃん)", Author = "Tetsuko Kuroyanagi",
                PublicationDate = "1981"
            },
            new Book {Title = "Matilda", Author = "Roald Dahl", PublicationDate = "1988"},
            new Book {Title = "The Book Thief", Author = "Markus Zusak", PublicationDate = "2005"},
            new Book {Title = "The Horse Whisperer", Author = "Nicholas Evans", PublicationDate = "1995"},
            new Book {Title = "Goodnight Moon", Author = "Margaret Wise Brown", PublicationDate = "1947"},
            new Book
            {
                Title = "The Neverending Story (Die unendliche Geschichte)", Author = "Michael Ende",
                PublicationDate = "1979"
            },
            new Book {Title = "All the Light We Cannot See", Author = "Anthony Doerr", PublicationDate = "2014"},
            new Book {Title = "Fifty Shades of Grey", Author = "E. L. James", PublicationDate = "2011"},
            new Book {Title = "Where the Crawdads Sing", Author = "Delia Owens", PublicationDate = "2018"},
            new Book {Title = "The Outsiders", Author = "S. E. Hinton", PublicationDate = "1967"},
            new Book {Title = "Guess How Much I Love You", Author = "Sam McBratney", PublicationDate = "1994"},
            new Book {Title = "Shōgun", Author = "James Clavell", PublicationDate = "1975"},
            new Book {Title = "The Poky Little Puppy", Author = "Janette Sebring Lowrey", PublicationDate = "1942"},
            new Book {Title = "The Pillars of the Earth", Author = "Ken Follett", PublicationDate = "1989"},
            new Book {Title = "Perfume (Das Parfum)", Author = "Patrick Süskind", PublicationDate = "1985"},
            new Book {Title = "The Grapes of Wrath", Author = "John Steinbeck", PublicationDate = "1939"},
            new Book
            {
                Title = "The Shadow of the Wind (La sombra del viento)", Author = "Carlos Ruiz Zafón",
                PublicationDate = "2001"
            },
            new Book {Title = "Interpreter of Maladies", Author = "Jhumpa Lahiri", PublicationDate = "2000"},
            new Book {Title = "Becoming", Author = "Michelle Obama", PublicationDate = "2018"},
            new Book
            {
                Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", PublicationDate = "1979"
            },
            new Book {Title = "Tuesdays with Morrie", Author = "Mitch Albom", PublicationDate = "1997"},
            new Book {Title = "God's Little Acre", Author = "Erskine Caldwell", PublicationDate = "1933"},
            new Book
            {
                Title = "Follow Your Heart (Va' dove ti porta il cuore)", Author = "Susanna Tamaro",
                PublicationDate = "1994"
            },
            new Book {Title = "A Wrinkle in Time", Author = "Madeleine L'Engle", PublicationDate = "1962"},
            new Book {Title = "Long Walk to Freedom", Author = "Nelson Mandela", PublicationDate = "1994"},
            new Book {Title = "The Old Man and the Sea", Author = "Ernest Hemingway", PublicationDate = "1952"},
            new Book {Title = "Life After Life", Author = "Raymond Moody", PublicationDate = "1975"},
            new Book {Title = "Me Before You", Author = "Jojo Moyes", PublicationDate = "2012"},
            new Book {Title = "Norwegian Wood (ノルウェイの森)", Author = "Haruki Murakami", PublicationDate = "1987"},
            new Book {Title = "Peyton Place", Author = "Grace Metalious", PublicationDate = "1956"},
            new Book {Title = "The Plague (La Peste)", Author = "Albert Camus", PublicationDate = "1947"},
            new Book {Title = "No Longer Human (人間失格)", Author = "Osamu Dazai", PublicationDate = "1948"},
            new Book
            {
                Title = "Man's Search for Meaning (Ein Psychologe erlebt das Konzentrationslager)",
                Author = "Viktor Frankl", PublicationDate = "1946"
            },
            new Book
            {
                Title = "The Divine Comedy (La Divina Commedia)", Author = "Dante Alighieri", PublicationDate = "1304"
            },
            new Book {Title = "The Prophet", Author = "Kahlil Gibran", PublicationDate = "1923"},
            new Book {Title = "The Boy in the Striped Pyjamas", Author = "John Boyne", PublicationDate = "2006"},
            new Book {Title = "The Exorcist", Author = "William Peter Blatty", PublicationDate = "1971"},
            new Book {Title = "The Gruffalo", Author = "Julia Donaldson", PublicationDate = "1999"},
            new Book {Title = "Fifty Shades Darker", Author = "E. L. James", PublicationDate = "2012"},
            new Book {Title = "Ronia, the Robber's Daughter", Author = "Astrid Lindgren", PublicationDate = "1981"},
            new Book {Title = "The Cat in the Hat", Author = "Dr. Seuss", PublicationDate = "1957"},
            new Book {Title = "Diana: Her True Story", Author = "Andrew Morton", PublicationDate = "1992"},
            new Book {Title = "The Help", Author = "Kathryn Stockett", PublicationDate = "2009"},
            new Book {Title = "Catch-22", Author = "Joseph Heller", PublicationDate = "1961"},
            new Book {Title = "The Stranger (L'Étranger)", Author = "Albert Camus", PublicationDate = "1942"},
            new Book {Title = "Eye of the Needle", Author = "Ken Follett", PublicationDate = "1978"},
            new Book {Title = "The Lovely Bones", Author = "Alice Sebold", PublicationDate = "2002"},
            new Book {Title = "Wild Swans", Author = "Jung Chang", PublicationDate = "1992"},
            new Book {Title = "Santa Evita", Author = "Tomás Eloy Martínez", PublicationDate = "1995"},
            new Book {Title = "Night (Un di Velt Hot Geshvign)", Author = "Elie Wiesel", PublicationDate = "1958"},
            new Book {Title = "Confucius from the Heart (于丹《论语》心得)", Author = "Yu Dan", PublicationDate = "2006"},
            new Book {Title = "The Total Woman", Author = "Marabel Morgan", PublicationDate = "1974"},
            new Book {Title = "Knowledge-value Revolution (知価革命)", Author = "Taichi Sakaiya", PublicationDate = "1985"},
            new Book
            {
                Title = "Problems in China's Socialist Economy (中国社会主义经济问题研究)", Author = "Xue Muqiao",
                PublicationDate = "1979"
            },
            new Book
            {
                Title = "What Color Is Your Parachute?", Author = "Richard Nelson Bolles", PublicationDate = "1970"
            },
            new Book {Title = "The Dukan Diet", Author = "Pierre Dukan", PublicationDate = "2000"},
            new Book {Title = "The Joy of Sex", Author = "Alex Comfort", PublicationDate = "1972"},
            new Book {Title = "The Gospel According to Peanuts", Author = "Robert L. Short", PublicationDate = "1965"},
            new Book {Title = "The Subtle Art of Not Giving a Fuck", Author = "Mark Manson", PublicationDate = "2016"},
            new Book {Title = "Life of Pi", Author = "Yann Martel", PublicationDate = "2001"},
            new Book {Title = "The Giver", Author = "Lois Lowry", PublicationDate = "1993"},
            new Book {Title = "The Front Runner", Author = "Patricia Nell Warren", PublicationDate = "1974"},
            new Book {Title = "The Goal", Author = "Eliyahu M. Goldratt", PublicationDate = "1984"},
            new Book {Title = "Fahrenheit 451", Author = "Ray Bradbury", PublicationDate = "1953"},
            new Book {Title = "Angela's Ashes", Author = "Frank McCourt", PublicationDate = "1996"},
            new Book
            {
                Title = "The Story of My Experiments with Truth (સત્યના પ્રયોગો અથવા આત્મકથા)",
                Author = "Mohandas Karamchand Gandhi", PublicationDate = "1925"
            },
            new Book {Title = "Bridget Jones's Diary", Author = "Helen Fielding", PublicationDate = "1996"},
            new Book {Title = "Harry Potter", Author = "J. K. Rowling", PublicationDate = "1997"},
            new Book {Title = "Goosebumps", Author = "R. L. Stine", PublicationDate = "1992"},
            new Book {Title = "Perry Mason", Author = "Erle Stanley Gardner", PublicationDate = "1933"},
            new Book {Title = "Berenstain Bears", Author = "Stan and Jan Berenstain", PublicationDate = "1962"},
            new Book {Title = "Choose Your Own Adventure", Author = "Various authors", PublicationDate = "1979"},
            new Book {Title = "Diary of a Wimpy Kid", Author = "Jeff Kinney", PublicationDate = "2007"},
            new Book
            {
                Title = "Sweet Valley High", Author = "Francine Pascal and ghostwriters", PublicationDate = "1983"
            },
            new Book
            {
                Title = "The Railway Series", Author = "Rev. W. Awdry, Christopher Awdry", PublicationDate = "1945"
            },
            new Book {Title = "Noddy", Author = "Enid Blyton", PublicationDate = "1949"},
            new Book {Title = "Nancy Drew", Author = "Various authors as Carolyn Keene", PublicationDate = "1930"},
            new Book {Title = "San-Antonio", Author = "Frédéric Dard", PublicationDate = "1949"},
            new Book {Title = "Robert Langdon", Author = "Dan Brown", PublicationDate = "2000"},
            new Book {Title = "Geronimo Stilton", Author = "Elisabetta Dami", PublicationDate = "1997"},
            new Book {Title = "Percy Jackson & the Olympians", Author = "Rick Riordan", PublicationDate = "2005"},
            new Book {Title = "The Baby-sitters Club", Author = "Ann Martin", PublicationDate = "1986"},
            new Book {Title = "Twilight", Author = "Stephenie Meyer", PublicationDate = "2005"},
            new Book {Title = "Star Wars", Author = "Various authors", PublicationDate = "1977"},
            new Book {Title = "Little Critter", Author = "Mercer Mayer", PublicationDate = "1975"},
            new Book {Title = "Peter Rabbit", Author = "Beatrix Potter", PublicationDate = "1902"},
            new Book {Title = "Fifty Shades", Author = "E. L. James", PublicationDate = "2011"},
            new Book {Title = "American Girl", Author = "Various authors", PublicationDate = "1986"},
            new Book
            {
                Title = "Chicken Soup for the Soul", Author = "Jack Canfield, Mark Victor Hansen",
                PublicationDate = "1997"
            },
            new Book {Title = "Clifford the Big Red Dog", Author = "Norman Bridwell", PublicationDate = "1963"},
            new Book {Title = "Frank Merriwell", Author = "Gilbert Patten", PublicationDate = "1896"},
            new Book {Title = "Dirk Pitt", Author = "Clive Cussler", PublicationDate = "1973"},
            new Book {Title = "宮本武蔵 (Musashi)", Author = "Eiji Yoshikawa", PublicationDate = "1935"},
            new Book {Title = "The Chronicles of Narnia", Author = "C. S. Lewis", PublicationDate = "1950"},
            new Book {Title = "Mr. Men", Author = "Roger Hargreaves, Adam Hargreaves", PublicationDate = "1971"},
            new Book {Title = "SAS", Author = "Gérard de Villiers", PublicationDate = "1965"},
            new Book {Title = "The Hunger Games trilogy", Author = "Suzanne Collins", PublicationDate = "2008"},
            new Book {Title = "James Bond", Author = "Ian Fleming", PublicationDate = "1953"},
            new Book {Title = "Martine", Author = "Gilbert Delahaye, Marcel Marlier", PublicationDate = "1954"},
            new Book {Title = "Millennium", Author = "Stieg Larsson, David Lagercrantz", PublicationDate = "2005"},
            new Book {Title = "A Song of Ice and Fire", Author = "George R. R. Martin", PublicationDate = "1996"},
            new Book
            {
                Title = "The Wheel of Time", Author = "Robert Jordan, Brandon Sanderson", PublicationDate = "1990"
            },
            new Book {Title = "Discworld", Author = "Terry Pratchett", PublicationDate = "1983"},
            new Book {Title = "Nijntje (Miffy)", Author = "Dick Bruna", PublicationDate = "1955"},
            new Book {Title = "Alex Cross", Author = "James Patterson", PublicationDate = "1993"},
            new Book {Title = "Anpanman (アンパンマン)", Author = "Takashi Yanase", PublicationDate = "1973"},
            new Book {Title = "Captain Underpants", Author = "Dav Pilkey", PublicationDate = "1997"},
            new Book {Title = "Fear Street", Author = "R. L. Stine", PublicationDate = "1989"},
            new Book
            {
                Title = "Pippi Långstrump (Pippi Longstocking)", Author = "Astrid Lindgren", PublicationDate = "1945"
            },
            new Book {Title = "The Vampire Chronicles", Author = "Anne Rice", PublicationDate = "1976"},
            new Book {Title = "OSS 117", Author = "Jean Bruce", PublicationDate = "1949"},
            new Book
            {
                Title = "Winnie-the-Pooh", Author = "A. A. Milne; illustrated by E. H. Shepard",
                PublicationDate = "1926"
            },
            new Book {Title = "Magic Tree House series", Author = "Mary Pope Osborne", PublicationDate = "1992"},
            new Book {Title = "Left Behind", Author = "Tim LaHaye, Jerry B. Jenkins", PublicationDate = "1996"},
            new Book
            {
                Title = "A Series of Unfortunate Events", Author = "Lemony Snicket aka Daniel Handler",
                PublicationDate = "1999"
            },
            new Book {Title = "Little House on the Prairie", Author = "Laura Ingalls Wilder", PublicationDate = "1932"},
            new Book
            {
                Title = "All Creatures Great and Small", Author = "Alf Wight, as James Herriot",
                PublicationDate = "1970"
            },
            new Book {Title = "Jack Reacher", Author = "Lee Child", PublicationDate = "1997"},
            new Book
            {
                Title = "The Magic School Bus", Author = "Joanna Cole, illustrated by Bruce Degen",
                PublicationDate = "1986"
            },
            new Book {Title = "Where's Wally?[223]", Author = "Martin Handford", PublicationDate = "1987"},
            new Book
            {
                Title = "Men Are from Mars, Women Are from Venus", Author = "John Gray", PublicationDate = "1992"
            },
            new Book
            {
                Title = "The Hardy Boys", Author = "Various authors as Franklin W. Dixon", PublicationDate = "1927"
            },
            new Book
            {
                Title = "The Bobbsey Twins", Author = "Various authors as Laura Lee Hope", PublicationDate = "1904"
            },
            new Book {Title = "Tarzan", Author = "Edgar Rice Burroughs", PublicationDate = "1914"},
            new Book {Title = "Earth's Children", Author = "Jean M. Auel", PublicationDate = "1980"},
            new Book
            {
                Title = "A Child's First Library Of Learning", Author = "Various authors", PublicationDate = "1980"
            },
            new Book {Title = "Junie B. Jones", Author = "Barbara Park", PublicationDate = "1992"},
            new Book {Title = "Harry Bosch", Author = "Michael Connelly", PublicationDate = "1992"},
            new Book {Title = "Harry Hole", Author = "Jo Nesbø", PublicationDate = "1997"},
            new Book {Title = "Warriors", Author = "Erin Hunter", PublicationDate = "2003"},
            new Book
            {
                Title = "连环画 铁道游击队 (Picture-and-story book Railway Guerilla)", Author = "original author: Liu Zhixia",
                PublicationDate = "1955"
            },
            new Book {Title = "The Shadowhunter Chronicles", Author = "Cassandra Clare", PublicationDate = "2007"},
            new Book {Title = "かいけつゾロリ (Kaiketsu Zorori)", Author = "Yutaka Hara", PublicationDate = "1987"},
            new Book {Title = "Paddington Bear", Author = "Michael Bond", PublicationDate = "1958"},
            new Book {Title = "Divergent trilogy", Author = "Veronica Roth", PublicationDate = "2011"},
            new Book {Title = "ノンタン (Nontan)", Author = "Sachiko Kiyono", PublicationDate = "1976"},
            new Book {Title = "The Inheritance Cycle", Author = "Christopher Paolini", PublicationDate = "2002"},
            new Book
            {
                Title = "Rich Dad, Poor Dad", Author = "Robert Kiyosaki, Sharon Lechter", PublicationDate = "1997"
            },
            new Book
            {
                Title = "とある魔術の禁書目録 (Toaru Majutsu no Index)", Author = "Kazuma Kamachi", PublicationDate = "2004"
            },
            new Book {Title = "グイン・サーガ (Guin Saga)", Author = "Kaoru Kurimoto", PublicationDate = "1979"},
            new Book {Title = "徳川家康 (Tokugawa Ieyasu)", Author = "Sōhachi Yamaoka", PublicationDate = "1950"},
            new Book {Title = "Ramona", Author = "Beverly Cleary", PublicationDate = "1955"},
            new Book {Title = "The Dark Tower", Author = "Stephen King", PublicationDate = "1982"},
            new Book {Title = "Dork Diaries", Author = "Rachel Renée Russell", PublicationDate = "2009"},
            new Book
            {
                Title = "The Destroyer", Author = "Warren Murphy and Richard Sapir, various authors",
                PublicationDate = "1971"
            },
            new Book {Title = "Curious George", Author = "Hans Augusto Rey and Margret Rey", PublicationDate = "1941"},
            new Book {Title = "Shannara", Author = "Terry Brooks", PublicationDate = "1977"},
            new Book {Title = "Kurt Wallander", Author = "Henning Mankell", PublicationDate = "1991"},
            new Book
            {
                Title = "Sagan om Isfolket (The Legend of the Ice People)", Author = "Margit Sandemo",
                PublicationDate = "1982"
            },
            new Book {Title = "The Sword of Truth", Author = "Terry Goodkind", PublicationDate = "1998"},
            new Book {Title = "Outlander", Author = "Diana Gabaldon", PublicationDate = "1991"},
            new Book {Title = "ズッコケ三人組 (Zukkoke Sanningumi)", Author = "Masamoto Nasu", PublicationDate = "1978"},
            new Book {Title = "鬼平犯科帳 (Onihei Hankachō)", Author = "Shōtarō Ikenami", PublicationDate = "1968"},
            new Book {Title = "Brain Quest", Author = "Various authors", PublicationDate = "1992"},
            new Book {Title = "South Beach Diet", Author = "Arthur Agatston", PublicationDate = "2003"},
            new Book {Title = "ソードアート・オンライン (Sword Art Online)", Author = "Reki Kawahara", PublicationDate = "2009"},
            new Book {Title = "竜馬がゆく (Ryoma ga Yuku)", Author = "Ryōtarō Shiba", PublicationDate = "1963"},
            new Book {Title = "Artemis Fowl", Author = "Eoin Colfer", PublicationDate = "2001"},
            new Book {Title = "I Survived", Author = "Lauren Tarshis", PublicationDate = "2010"},
            new Book {Title = "Découvertes Gallimard", Author = "Various authors", PublicationDate = "1986"},
            new Book {Title = "Redwall", Author = "Brian Jacques", PublicationDate = "1986"},
            new Book {Title = "Maisy", Author = "Lucy Cousins", PublicationDate = "1990"},
            new Book {Title = "Dragonlance", Author = "Various authors", PublicationDate = "1984"},
            new Book {Title = "幻魔大戦 (Genma Taisen)", Author = "Kazumasa Hirai", PublicationDate = "1979"},
            new Book {Title = "青春の門 (The Gate of Youth)", Author = "Hiroyuki Itsuki", PublicationDate = "1970"},
            new Book {Title = "スレイヤーズ (Slayers)", Author = "Hajime Kanzaka", PublicationDate = "1989"},
            new Book {Title = "The Foundation Trilogy", Author = "Isaac Asimov", PublicationDate = "1950"},
            new Book {Title = "Horrible Histories", Author = "Terry Deary", PublicationDate = "1993"},
            new Book {Title = "Rainbow Magic", Author = "Daisy Meadows", PublicationDate = "2003"},
            new Book {Title = "Morgan Kane", Author = "Louis Masterson", PublicationDate = "1966"},
            new Book {Title = "The Southern Vampire Mysteries", Author = "Charlaine Harris", PublicationDate = "2001"},
            new Book {Title = "Doc Savage", Author = "Lester Dent, various authors", PublicationDate = "1933"},
            new Book
            {
                Title = "涼宮ハルヒシリーズ (Haruhi Suzumiya Series)", Author = "Nagaru Tanigawa", PublicationDate = "2003"
            },
            new Book {Title = "科学のアルバム (Kagaku no album)", Author = "Various authors", PublicationDate = "1970"},
            new Book {Title = "剣客商売 (Kenkaku Shobai)", Author = "Shotaro Ikenami", PublicationDate = "1972"},
            new Book {Title = "Erast Fandorin series", Author = "Boris Akunin", PublicationDate = "1998"},
            new Book {Title = "Dragonriders of Pern", Author = "Anne McCaffrey", PublicationDate = "1967"},
            new Book {Title = "吸血鬼ハンターD (Vampire Hunter D)", Author = "Hideyuki Kikuchi", PublicationDate = "1983"},
            new Book
            {
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams, plus a final book by Eoin Colfer", PublicationDate = "1979"
            },
            new Book {Title = "ぼくらシリーズ (Bokura series)", Author = "Osamu Soda", PublicationDate = "1985"},
            new Book {Title = "Bridget Jones", Author = "Helen Fielding", PublicationDate = "1996"},
            new Book {Title = "His Dark Materials", Author = "Philip Pullman", PublicationDate = "1995"},
            new Book
            {
                Title = "銀河英雄伝説 (Legend of the Galactic Heroes)", Author = "Yoshiki Tanaka", PublicationDate = "1982"
            },
            new Book
            {
                Title = "The No. 1 Ladies Detective Agency", Author = "Alexander McCall Smith", PublicationDate = "1999"
            },
            new Book
            {
                Title = "Der Regenbogenfisch (Rainbow Fish)", Author = "Marcus Pfister", PublicationDate = "1992"
            },
            new Book {Title = "The Riftwar Cycle", Author = "Raymond E. Feist", PublicationDate = "1982"},
            new Book {Title = "Wiedźmin (The Witcher)", Author = "Andrzej Sapkowski", PublicationDate = "1990"}
        };

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string PublicationDate { get; set; }
        }
    }

    

    /*

,(N'The Tale of Peter Rabbit', N'Beatrix Potter', '1902')
,(N'Jonathan Livingston Seagull', N'Richard Bach', '1970')
,(N'The Very Hungry Caterpillar', N'Eric Carle', '1969')
,(N'A Message to Garcia', N'Elbert Hubbard', '1899')
,(N'To Kill a Mockingbird', N'Harper Lee', '1960')
,(N'Flowers in the Attic', N'V. C. Andrews', '1979')
,(N'Cosmos', N'Carl Sagan', '1980')
,(N'Sophie's World (Sofies verden)', N'Jostein Gaarder', '1991')
,(N'Angels & Demons', N'Dan Brown', '2000')
,(N'Kane and Abel', N'Jeffrey Archer', '1979')
,(N'How the Steel Was Tempered (Как закалялась сталь)', N'Nikolai Ostrovsky', '1932')
,(N'War and Peace (Война и мир)', N'Leo Tolstoy', '1869')
,(N'The Adventures of Pinocchio (Le avventure di Pinocchio)', N'Carlo Collodi', '1881')
,(N'The Diary of Anne Frank (Het Achterhuis)', N'Anne Frank', '1947')
,(N'Your Erroneous Zones', N'Wayne Dyer', '1976')
,(N'The Thorn Birds', N'Colleen McCullough', '1977')
,(N'The Purpose Driven Life', N'Rick Warren', '2002')
,(N'The Kite Runner', N'Khaled Hosseini', '2003')
,(N'Valley of the Dolls', N'Jacqueline Susann', '1966')
,(N'Alcoholics Anonymous Big Book', N'Bill Wilson', '1939')
,(N'How to Win Friends and Influence People', N'Dale Carnegie', '1936')
,(N'The Great Gatsby', N'F. Scott Fitzgerald', '1925')
,(N'Gone with the Wind', N'Margaret Mitchell', '1936')
,(N'Rebecca', N'Daphne du Maurier', '1938')
,(N'Nineteen Eighty-Four', N'George Orwell', '1949')
,(N'The Revolt of Mamie Stover', N'William Bradford Huie', '1951')
,(N'The Girl with the Dragon Tattoo (Män som hatar kvinnor)', N'Stieg Larsson', '2005')
,(N'The Lost Symbol', N'Dan Brown', '2009')
,(N'The Hunger Games', N'Suzanne Collins', '2008')
,(N'James and the Giant Peach', N'Roald Dahl', '1961')
,(N'The Young Guard (Молодая гвардия)', N'Alexander Alexandrovich Fadeyev', '1945')
,(N'Who Moved My Cheese?', N'Spencer Johnson', '1998')
,(N'A Brief History of Time', N'Stephen Hawking', '1988')
,(N'Paul et Virginie', N'Jacques-Henri Bernardin de Saint-Pierre', '1788')
,(N'Lust for Life', N'Irving Stone', '1934')
,(N'The Wind in the Willows', N'Kenneth Grahame', '1908')
,(N'The 7 Habits of Highly Effective People', N'Stephen R. Covey', '1989')
,(N'Virgin Soil Upturned (Поднятая целина)', N'Mikhail Sholokhov', '1935')
,(N'The Celestine Prophecy', N'James Redfield', '1993')
,(N'The Fault in Our Stars', N'John Green', '2012')
,(N'The Girl on the Train', N'Paula Hawkins', '2015')
,(N'The Shack', N'William P. Young', '2007')
,(N'Uncle Styopa (Дядя Стёпа)', N'Sergey Mikhalkov', '1936')
,(N'The Godfather', N'Mario Puzo', '1969')
,(N'Love Story', N'Erich Segal', '1970')
,(N'Catching Fire', N'Suzanne Collins', '2009')
,(N'Mockingjay', N'Suzanne Collins', '2010')
,(N'Kitchen', N'Banana Yoshimoto', '1988')
,(N'Andromeda Nebula', N'Ivan Yefremov', '1957')
,(N'Autobiography of a Yogi', N'Paramahansa Yogananda', '1946')
,(N'Gone Girl', N'Gillian Flynn', '2012')
,(N'All Quiet on the Western Front (Im Westen nichts Neues)', N'Erich Maria Remarque', '1929')
,(N'The Bermuda Triangle', N'Charles Berlitz', '1974')
,(N'Things Fall Apart', N'Chinua Achebe', '1958')
,(N'Animal Farm', N'George Orwell', '1945')
,(N'Wolf Totem (狼图腾)', N'Jiang Rong', '2004')
,(N'The Happy Hooker: My Own Story', N'Xaviera Hollander', '1971')
,(N'Jaws', N'Peter Benchley', '1974')
,(N'Love You Forever', N'Robert Munsch', '1986')
,(N'The Women's Room', N'Marilyn French', '1977')
,(N'What to Expect When You're Expecting', N'Arlene Eisenberg and Heidi Murkoff', '1984')
,(N'Adventures of Huckleberry Finn', N'Mark Twain', '1885')
,(N'The Secret Diary of Adrian Mole, Aged 13¾', N'Sue Townsend', '1982')
,(N'Pride and Prejudice', N'Jane Austen', '1813')
,(N'Kon-Tiki: Across the Pacific in a Raft (Kon-Tiki ekspedisjonen)', N'Thor Heyerdahl', '1950')
,(N'The Good Soldier Švejk (Osudy dobrého vojáka Švejka za světové války)', N'Jaroslav Hašek', '1923')
,(N'Where the Wild Things Are', N'Maurice Sendak', '1963')
,(N'The Power of Positive Thinking', N'Norman Vincent Peale', '1952')
,(N'The Secret', N'Rhonda Byrne', '2006')
,(N'Fear of Flying', N'Erica Jong', '1973')
,(N'Dune', N'Frank Herbert', '1965')
,(N'Charlie and the Chocolate Factory', N'Roald Dahl', '1964')
,(N'The Naked Ape', N'Desmond Morris', '1968')
,(N'Totto-chan, the Little Girl at the Window (窓ぎわのトットちゃん)', N'Tetsuko Kuroyanagi', '1981')
,(N'Matilda', N'Roald Dahl', '1988')
,(N'The Book Thief', N'Markus Zusak', '2005')
,(N'The Horse Whisperer', N'Nicholas Evans', '1995')
,(N'Goodnight Moon', N'Margaret Wise Brown', '1947')
,(N'The Neverending Story (Die unendliche Geschichte)', N'Michael Ende', '1979')
,(N'All the Light We Cannot See', N'Anthony Doerr', '2014')
,(N'Fifty Shades of Grey', N'E. L. James', '2011')
,(N'Where the Crawdads Sing', N'Delia Owens', '2018')
,(N'The Outsiders', N'S. E. Hinton', '1967')
,(N'Guess How Much I Love You', N'Sam McBratney', '1994')
,(N'Shōgun', N'James Clavell', '1975')
,(N'The Poky Little Puppy', N'Janette Sebring Lowrey', '1942')
,(N'The Pillars of the Earth', N'Ken Follett', '1989')
,(N'Perfume (Das Parfum)', N'Patrick Süskind', '1985')
,(N'The Grapes of Wrath', N'John Steinbeck', '1939')
,(N'The Shadow of the Wind (La sombra del viento)', N'Carlos Ruiz Zafón', '2001')
,(N'Interpreter of Maladies', N'Jhumpa Lahiri', '2000')
,(N'Becoming', N'Michelle Obama', '2018')
,(N'The Hitchhiker's Guide to the Galaxy', N'Douglas Adams', '1979')
,(N'Tuesdays with Morrie', N'Mitch Albom', '1997')
,(N'God's Little Acre', N'Erskine Caldwell', '1933')
,(N'Follow Your Heart (Va' dove ti porta il cuore)', N'Susanna Tamaro', '1994')
,(N'A Wrinkle in Time', N'Madeleine L'Engle', '1962')
,(N'Long Walk to Freedom', N'Nelson Mandela', '1994')
,(N'The Old Man and the Sea', N'Ernest Hemingway', '1952')
,(N'Life After Life', N'Raymond Moody', '1975')
,(N'Me Before You', N'Jojo Moyes', '2012')
,(N'Norwegian Wood (ノルウェイの森)', N'Haruki Murakami', '1987')
,(N'Peyton Place', N'Grace Metalious', '1956')
,(N'The Plague (La Peste)', N'Albert Camus', '1947')
,(N'No Longer Human (人間失格)', N'Osamu Dazai', '1948')
,(N'Man's Search for Meaning (Ein Psychologe erlebt das Konzentrationslager)', N'Viktor Frankl', '1946')
,(N'The Divine Comedy (La Divina Commedia)', N'Dante Alighieri', '1304')
,(N'The Prophet', N'Kahlil Gibran', '1923')
,(N'The Boy in the Striped Pyjamas', N'John Boyne', '2006')
,(N'The Exorcist', N'William Peter Blatty', '1971')
,(N'The Gruffalo', N'Julia Donaldson', '1999')
,(N'Fifty Shades Darker', N'E. L. James', '2012')
,(N'Ronia, the Robber's Daughter', N'Astrid Lindgren', '1981')
,(N'The Cat in the Hat', N'Dr. Seuss', '1957')
,(N'Diana: Her True Story', N'Andrew Morton', '1992')
,(N'The Help', N'Kathryn Stockett', '2009')
,(N'Catch-22', N'Joseph Heller', '1961')
,(N'The Stranger (L'Étranger)', N'Albert Camus', '1942')
,(N'Eye of the Needle', N'Ken Follett', '1978')
,(N'The Lovely Bones', N'Alice Sebold', '2002')
,(N'Wild Swans', N'Jung Chang', '1992')
,(N'Santa Evita', N'Tomás Eloy Martínez', '1995')
,(N'Night (Un di Velt Hot Geshvign)', N'Elie Wiesel', '1958')
,(N'Confucius from the Heart (于丹《论语》心得)', N'Yu Dan', '2006')
,(N'The Total Woman', N'Marabel Morgan', '1974')
,(N'Knowledge-value Revolution (知価革命)', N'Taichi Sakaiya', '1985')
,(N'Problems in China's Socialist Economy (中国社会主义经济问题研究)', N'Xue Muqiao', '1979')
,(N'What Color Is Your Parachute?', N'Richard Nelson Bolles', '1970')
,(N'The Dukan Diet', N'Pierre Dukan', '2000')
,(N'The Joy of Sex', N'Alex Comfort', '1972')
,(N'The Gospel According to Peanuts', N'Robert L. Short', '1965')
,(N'The Subtle Art of Not Giving a Fuck', N'Mark Manson', '2016')
,(N'Life of Pi', N'Yann Martel', '2001')
,(N'The Giver', N'Lois Lowry', '1993')
,(N'The Front Runner', N'Patricia Nell Warren', '1974')
,(N'The Goal', N'Eliyahu M. Goldratt', '1984')
,(N'Fahrenheit 451', N'Ray Bradbury', '1953')
,(N'Angela's Ashes', N'Frank McCourt', '1996')
,(N'The Story of My Experiments with Truth (સત્યના પ્રયોગો અથવા આત્મકથા)', N'Mohandas Karamchand Gandhi', '1925'	)
,(N'Bridget Jones's Diary', N'Helen Fielding', '1996')
,(N'Harry Potter', N'J. K. Rowling', '1997'	)
,(N'Goosebumps', N'R. L. Stine', '1992'	)
,(N'Perry Mason', N'Erle Stanley Gardner', '1933'	)
,(N'Berenstain Bears', N'Stan and Jan Berenstain', '1962'	)
,(N'Choose Your Own Adventure', N'Various authors', '1979'	)
,(N'Diary of a Wimpy Kid', N'Jeff Kinney', '2007'	)
,(N'Sweet Valley High', N'Francine Pascal and ghostwriters', '1983'	)
,(N'The Railway Series', N'Rev. W. Awdry, Christopher Awdry', '1945'	)
,(N'Noddy', N'Enid Blyton', '1949'	)
,(N'Nancy Drew', N'Various authors as Carolyn Keene', '1930'	)
,(N'San-Antonio', N'Frédéric Dard', '1949'	)
,(N'Robert Langdon', N'Dan Brown', '2000'	)
,(N'Geronimo Stilton', N'Elisabetta Dami', '1997-present	)
,(N'Percy Jackson & the Olympians', N'Rick Riordan', '2005'	)
,(N'The Baby-sitters Club', N'Ann Martin', '1986'	)
,(N'Twilight', N'Stephenie Meyer', '2005'	)
,(N'Star Wars', N'Various authors', '1977'	)
,(N'Little Critter', N'Mercer Mayer', '1975'	)
,(N'Peter Rabbit', N'Beatrix Potter', '1902'	)
,(N'Fifty Shades', N'E. L. James', '2011'	)
,(N'American Girl', N'Various authors', '1986'	)
,(N'Chicken Soup for the Soul', N'Jack Canfield, Mark Victor Hansen', '1997'	)
,(N'Clifford the Big Red Dog', N'Norman Bridwell', '1963'	)
,(N'Frank Merriwell', N'Gilbert Patten', '1896'	)
,(N'Dirk Pitt', N'Clive Cussler', '1973'	)
,(N'宮本武蔵 (Musashi)', N'Eiji Yoshikawa', '1935'	)
,(N'The Chronicles of Narnia', N'C. S. Lewis', '1950'	)
,(N'Mr. Men', N'Roger Hargreaves, Adam Hargreaves', '1971'	)
,(N'SAS', N'Gérard de Villiers', '1965'	)
,(N'The Hunger Games trilogy', N'Suzanne Collins', '2008'	)
,(N'James Bond', N'Ian Fleming', '1953'	)
,(N'Martine', N'Gilbert Delahaye, Marcel Marlier', '1954'	)
,(N'Millennium', N'Stieg Larsson, David Lagercrantz', '2005'	)
,(N'A Song of Ice and Fire', N'George R. R. Martin', '1996'	)
,(N'The Wheel of Time', N'Robert Jordan, Brandon Sanderson', '1990'	)
,(N'Discworld', N'Terry Pratchett', '1983'	)
,(N'Nijntje (Miffy)', N'Dick Bruna', '1955'	)
,(N'Alex Cross', N'James Patterson', '1993'	)
,(N'Anpanman (アンパンマン)', N'Takashi Yanase', '1973'	)
,(N'Captain Underpants', N'Dav Pilkey', '1997'	)
,(N'Fear Street', N'R. L. Stine', '1989'	)
,(N'Pippi Långstrump (Pippi Longstocking)', N'Astrid Lindgren', '1945'	)
,(N'The Vampire Chronicles', N'Anne Rice', '1976'	)
,(N'OSS 117', N'Jean Bruce', '1949'	)
,(N'Winnie-the-Pooh', N'A. A. Milne; illustrated by E. H. Shepard', '1926'	)
,(N'Magic Tree House series', N'Mary Pope Osborne', '1992'	)
,(N'Left Behind', N'Tim LaHaye, Jerry B. Jenkins', '1996'	)
,(N'A Series of Unfortunate Events', N'Lemony Snicket aka Daniel Handler', '1999'	)
,(N'Little House on the Prairie', N'Laura Ingalls Wilder', '1932'	)
,(N'All Creatures Great and Small', N'Alf Wight, as James Herriot', '1970'	)
,(N'Jack Reacher', N'Lee Child', '1997'	)
,(N'The Magic School Bus', N'Joanna Cole, illustrated by Bruce Degen', '1986'	)
,(N'Where's Wally?[223]', N'Martin Handford', '1987'	)
,(N'Men Are from Mars, Women Are from Venus', N'John Gray', '1992'	)
,(N'The Hardy Boys', N'Various authors as Franklin W. Dixon', '1927'	)
,(N'The Bobbsey Twins', N'Various authors as Laura Lee Hope', '1904'	)
,(N'Tarzan', N'Edgar Rice Burroughs', '1914'	)
,(N'Earth's Children', N'Jean M. Auel', '1980'	)
,(N'A Child's First Library Of Learning', N'Various authors', '1980'	)
,(N'Junie B. Jones', N'Barbara Park', '1992'	)
,(N'Harry Bosch', N'Michael Connelly', '1992'	)
,(N'Harry Hole', N'Jo Nesbø', '1997'	)
,(N'Warriors', N'Erin Hunter', '2003'	)
,(N'连环画 铁道游击队 (Picture-and-story book Railway Guerilla)', N'original author: Liu Zhixia', '1955'	)
,(N'The Shadowhunter Chronicles', N'Cassandra Clare', '2007'	)
,(N'かいけつゾロリ (Kaiketsu Zorori)', N'Yutaka Hara', '1987'	)
,(N'Paddington Bear', N'Michael Bond', '1958'	)
,(N'Divergent trilogy', N'Veronica Roth', '2011'	)
,(N'ノンタン (Nontan)', N'Sachiko Kiyono', '1976'	)
,(N'The Inheritance Cycle', N'Christopher Paolini', '2002'	)
,(N'Rich Dad, Poor Dad', N'Robert Kiyosaki, Sharon Lechter', '1997'	)
,(N'とある魔術の禁書目録 (Toaru Majutsu no Index)', N'Kazuma Kamachi', '2004'	)
,(N'グイン・サーガ (Guin Saga)', N'Kaoru Kurimoto', '1979'	)
,(N'徳川家康 (Tokugawa Ieyasu)', N'Sōhachi Yamaoka', '1950'	)
,(N'Ramona', N'Beverly Cleary', '1955'	)
,(N'The Dark Tower', N'Stephen King', '1982'	)
,(N'Dork Diaries', N'Rachel Renée Russell', '2009'	)
,(N'The Destroyer', N'Warren Murphy and Richard Sapir, various authors', '1971'	)
,(N'Curious George', N'Hans Augusto Rey and Margret Rey', '1941'	)
,(N'Shannara', N'Terry Brooks', '1977'	)
,(N'Kurt Wallander', N'Henning Mankell', '1991'	)
,(N'Sagan om Isfolket (The Legend of the Ice People)', N'Margit Sandemo', '1982'	)
,(N'The Sword of Truth', N'Terry Goodkind', '1998'	)
,(N'Outlander', N'Diana Gabaldon', '1991'	)
,(N'ズッコケ三人組 (Zukkoke Sanningumi)', N'Masamoto Nasu', '1978'	)
,(N'鬼平犯科帳 (Onihei Hankachō)', N'Shōtarō Ikenami', '1968'	)
,(N'Brain Quest', N'Various authors', '1992'	)
,(N'South Beach Diet', N'Arthur Agatston', '2003'	)
,(N'ソードアート・オンライン (Sword Art Online)', N'Reki Kawahara', '2009'	)
,(N'竜馬がゆく (Ryoma ga Yuku)', N'Ryōtarō Shiba', '1963'	)
,(N'Artemis Fowl', N'Eoin Colfer', '2001'	)
,(N'I Survived', N'Lauren Tarshis', '2010'	)
,(N'Découvertes Gallimard', N'Various authors', '1986'	)
,(N'Redwall', N'Brian Jacques', '1986'	)
,(N'Maisy', N'Lucy Cousins', '1990'	)
,(N'Dragonlance', N'Various authors', '1984'	)
,(N'幻魔大戦 (Genma Taisen)', N'Kazumasa Hirai', '1979'	)
,(N'青春の門 (The Gate of Youth)', N'Hiroyuki Itsuki', '1970'	)
,(N'スレイヤーズ (Slayers)', N'Hajime Kanzaka', '1989'	)
,(N'The Foundation Trilogy', N'Isaac Asimov', '1950'	)
,(N'Horrible Histories', N'Terry Deary', '1993'	)
,(N'Rainbow Magic', N'Daisy Meadows', '2003'	)
,(N'Morgan Kane', N'Louis Masterson', '1966'	)
,(N'The Southern Vampire Mysteries', N'Charlaine Harris', '2001'	)
,(N'Doc Savage', N'Lester Dent, various authors', '1933'	)
,(N'涼宮ハルヒシリーズ (Haruhi Suzumiya Series)', N'Nagaru Tanigawa', '2003'	)
,(N'科学のアルバム (Kagaku no album)', N'Various authors', '1970'	)
,(N'剣客商売 (Kenkaku Shobai)', N'Shotaro Ikenami', '1972'	)
,(N'Erast Fandorin series', N'Boris Akunin', '1998'	)
,(N'Dragonriders of Pern', N'Anne McCaffrey', '1967'	)
,(N'吸血鬼ハンターD (Vampire Hunter D)', N'Hideyuki Kikuchi', '1983'	)
,(N'The Hitchhiker's Guide to the Galaxy', N'Douglas Adams, plus a final book by Eoin Colfer', '1979'	)
,(N'ぼくらシリーズ (Bokura series)', N'Osamu Soda', '1985'	)
,(N'Bridget Jones', N'Helen Fielding', '1996'	)
,(N'His Dark Materials', N'Philip Pullman', '1995'	)
,(N'銀河英雄伝説 (Legend of the Galactic Heroes)', N'Yoshiki Tanaka', '1982'	)
,(N'The No. 1 Ladies Detective Agency', N'Alexander McCall Smith', '1999'	)
,(N'Der Regenbogenfisch (Rainbow Fish)', N'Marcus Pfister', '1992'	)
,(N'The Riftwar Cycle', N'Raymond E. Feist', '1982'	)
,(N'Wiedźmin (The Witcher)', N'Andrzej Sapkowski', '1990'	)

    */
}
