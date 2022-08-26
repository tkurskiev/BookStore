# BookStore
## BookStore.Client project
First, start the BookStore.API project in the preferred way (with/without debugging). Then using command line tool or Visual Studio's terminal window,
cd into the folder with the project BookStore.Client, then use following commands in order to make requests to the API:
1. ```get``` with possible options:
    - ```--author```
    - ```--title```
    - ```--publicationDate```
    - ```--orderBy``` with possible values:
        - ```title```
        - ```author```
        - ```date```
    - ```--pageNumber```
    - ```--pageSize```
2. ```getByUri``` with option:
    - ```--uri```, which is **required**

3. ```buy``` with option:
    - ```--id```, which is **required**

### .NET CLI dotnet run commands
To make a get request to 

## BookStore.API project

### SQL Scripts

```
CREATE DATABASE BookStoreDb;
GO

USE BookStoreDb;
GO

CREATE TABLE Books
(
    id int  NOT NULL IDENTITY(1, 1),
    author nvarchar(256)  NOT NULL,
    title nvarchar(256)  NOT NULL,
    publication_date date NOT NULL,
    CONSTRAINT book_ak_1 UNIQUE (author, title),
    CONSTRAINT book_pk PRIMARY KEY  (id)
);
GO

INSERT INTO Books(author, title, publication_date)
VALUES (N'Beatrix Potter', N'The Tale of Peter Rabbit', '19020603')
,(N'Richard Bach', N'Jonathan Livingston Seagull', '19700420')
,(N'Eric Carle', N'The Very Hungry Caterpillar', '19690612')
,(N'Elbert Hubbard', N'A Message to Garcia', '18990716')
,(N'Harper Lee', N'To Kill a Mockingbird', '19600421')
,(N'V. C. Andrews', N'Flowers in the Attic', '19790117')
,(N'Carl Sagan', N'Cosmos', '19800517')
,(N'Jostein Gaarder', N'Sophie''s World (Sofies verden)', '19910617')
,(N'Dan Brown', N'Angels & Demons', '20000409')
,(N'Jeffrey Archer', N'Kane and Abel', '19790307')
,(N'Nikolai Ostrovsky', N'How the Steel Was Tempered (Как закалялась сталь)', '19320510')
,(N'Leo Tolstoy', N'War and Peace (Война и мир)', '18690115')
,(N'Carlo Collodi', N'The Adventures of Pinocchio (Le avventure di Pinocchio)', '18810519')
,(N'Anne Frank', N'The Diary of Anne Frank (Het Achterhuis)', '19470307')
,(N'Wayne Dyer', N'Your Erroneous Zones', '19760406')
,(N'Colleen McCullough', N'The Thorn Birds', '19770420')
,(N'Rick Warren', N'The Purpose Driven Life', '20020327')
,(N'Khaled Hosseini', N'The Kite Runner', '20030102')
,(N'Jacqueline Susann', N'Valley of the Dolls', '19660327')
,(N'Bill Wilson', N'Alcoholics Anonymous Big Book', '19390404')
,(N'Dale Carnegie', N'How to Win Friends and Influence People', '19360314')
,(N'F. Scott Fitzgerald', N'The Great Gatsby', '19250320')
,(N'Margaret Mitchell', N'Gone with the Wind', '19360206')
,(N'Daphne du Maurier', N'Rebecca', '19380622')
,(N'George Orwell', N'Nineteen Eighty-Four', '19490820')
,(N'William Bradford Huie', N'The Revolt of Mamie Stover', '19510122')
,(N'Stieg Larsson', N'The Girl with the Dragon Tattoo (Män som hatar kvinnor)', '20051021')
,(N'Dan Brown', N'The Lost Symbol', '20090707')
,(N'Suzanne Collins', N'The Hunger Games', '20081004')
,(N'Roald Dahl', N'James and the Giant Peach', '19610119')
,(N'Alexander Alexandrovich Fadeyev', N'The Young Guard (Молодая гвардия)', '19450210')
,(N'Spencer Johnson', N'Who Moved My Cheese?', '19981119')
,(N'Stephen Hawking', N'A Brief History of Time', '19881122')
,(N'Jacques-Henri Bernardin de Saint-Pierre', N'Paul et Virginie', '17880516')
,(N'Irving Stone', N'Lust for Life', '19340323')
,(N'Kenneth Grahame', N'The Wind in the Willows', '19081113')
,(N'Stephen R. Covey', N'The 7 Habits of Highly Effective People', '19890103')
,(N'Mikhail Sholokhov', N'Virgin Soil Upturned (Поднятая целина)', '19350414')
,(N'James Redfield', N'The Celestine Prophecy', '19930104')
,(N'John Green', N'The Fault in Our Stars', '20121126')
,(N'Paula Hawkins', N'The Girl on the Train', '20151107')
,(N'William P. Young', N'The Shack', '20070603')
,(N'Sergey Mikhalkov', N'Uncle Styopa (Дядя Стёпа)', '19360524')
,(N'Mario Puzo', N'The Godfather', '19691019')
,(N'Erich Segal', N'Love Story', '19700412')
,(N'Suzanne Collins', N'Catching Fire', '20090403')
,(N'Suzanne Collins', N'Mockingjay', '20100419')
,(N'Banana Yoshimoto', N'Kitchen', '19880123')
,(N'Ivan Yefremov', N'Andromeda Nebula', '19570302')
,(N'Paramahansa Yogananda', N'Autobiography of a Yogi', '19460210')
,(N'Gillian Flynn', N'Gone Girl', '20120627')
,(N'Erich Maria Remarque', N'All Quiet on the Western Front (Im Westen nichts Neues)', '19291019')
,(N'Charles Berlitz', N'The Bermuda Triangle', '19740606')
,(N'Chinua Achebe', N'Things Fall Apart', '19580527')
,(N'George Orwell', N'Animal Farm', '19450223')
,(N'Jiang Rong', N'Wolf Totem', '20040212')
,(N'Xaviera Hollander', N'The Happy Hooker: My Own Story', '19710817')
,(N'Peter Benchley', N'Jaws', '19740807')
,(N'Robert Munsch', N'Love You Forever', '19861104')
,(N'Marilyn French', N'The Women''s Room', '19770209')
,(N'Arlene Eisenberg and Heidi Murkoff', N'What to Expect When You''re Expecting', '19840526')
,(N'Mark Twain', N'Adventures of Huckleberry Finn', '18850623')
,(N'Sue Townsend', N'The Secret Diary of Adrian Mole, Aged 13¾', '19820215')
,(N'Jane Austen', N'Pride and Prejudice', '18131021')
,(N'Thor Heyerdahl', N'Kon-Tiki: Across the Pacific in a Raft (Kon-Tiki ekspedisjonen)', '19500419')
,(N'Jaroslav Hašek', N'The Good Soldier Švejk (Osudy dobrého vojáka Švejka za světové války)', '19231107')
,(N'Maurice Sendak', N'Where the Wild Things Are', '19630812')
,(N'Norman Vincent Peale', N'The Power of Positive Thinking', '19520910')
,(N'Rhonda Byrne', N'The Secret', '20060408')
,(N'Erica Jong', N'Fear of Flying', '19730427')
,(N'Frank Herbert', N'Dune', '19650609')
,(N'Roald Dahl', N'Charlie and the Chocolate Factory', '19641016')
,(N'Desmond Morris', N'The Naked Ape', '19680511')
,(N'Tetsuko Kuroyanagi', N'Totto-chan, the Little Girl at the Window', '19810802')
,(N'Roald Dahl', N'Matilda', '19880104')
,(N'Markus Zusak', N'The Book Thief', '20050409')
,(N'Nicholas Evans', N'The Horse Whisperer', '19950706')
,(N'Margaret Wise Brown', N'Goodnight Moon', '19471121')
,(N'Michael Ende', N'The Neverending Story (Die unendliche Geschichte)', '19790222')
,(N'Anthony Doerr', N'All the Light We Cannot See', '20140520')
,(N'E. L. James', N'Fifty Shades of Grey', '20110611')
,(N'Delia Owens', N'Where the Crawdads Sing', '20181117')
,(N'S. E. Hinton', N'The Outsiders', '19670727')
,(N'Sam McBratney', N'Guess How Much I Love You', '19940325')
,(N'James Clavell', N'Shōgun', '19750626')
,(N'Janette Sebring Lowrey', N'The Poky Little Puppy', '19420424')
,(N'Ken Follett', N'The Pillars of the Earth', '19890625')
,(N'Patrick Süskind', N'Perfume (Das Parfum)', '19850914')
,(N'John Steinbeck', N'The Grapes of Wrath', '19390711')
,(N'Carlos Ruiz Zafón', N'The Shadow of the Wind (La sombra del viento)', '20010706')
,(N'Jhumpa Lahiri', N'Interpreter of Maladies', '20000202')
,(N'Michelle Obama', N'Becoming', '20181017')
,(N'Douglas Adams', N'The Hitchhiker''s Guide to the Galaxy', '19790309')
,(N'Mitch Albom', N'Tuesdays with Morrie', '19970206')
,(N'Erskine Caldwell', N'God''s Little Acre', '19330425')
,(N'Susanna Tamaro', N'Follow Your Heart (Va'' dove ti porta il cuore)', '19940809')
,(N'Madeleine L''Engle', N'A Wrinkle in Time', '19620724')
,(N'Nelson Mandela', N'Long Walk to Freedom', '19940807')
,(N'Ernest Hemingway', N'The Old Man and the Sea', '19521026')
,(N'Raymond Moody', N'Life After Life', '19751015')
,(N'Jojo Moyes', N'Me Before You', '20121003')
,(N'Haruki Murakami', N'Norwegian Wood', '19870819')
,(N'Grace Metalious', N'Peyton Place', '19560516')
,(N'Albert Camus', N'The Plague (La Peste)', '19470823')
,(N'Osamu Dazai', N'No Longer Human', '19480203')
,(N'Viktor Frankl', N'Man''s Search for Meaning (Ein Psychologe erlebt das Konzentrationslager)', '19460921')
,(N'Dante Alighieri', N'The Divine Comedy (La Divina Commedia)', '13040219')
,(N'Kahlil Gibran', N'The Prophet', '19230302')
,(N'John Boyne', N'The Boy in the Striped Pyjamas', '20060810')
,(N'William Peter Blatty', N'The Exorcist', '19710111')
,(N'Julia Donaldson', N'The Gruffalo', '19990303')
,(N'E. L. James', N'Fifty Shades Darker', '20121010')
,(N'Astrid Lindgren', N'Ronia, the Robber''s Daughter', '19810515')
,(N'Dr. Seuss', N'The Cat in the Hat', '19571109')
,(N'Andrew Morton', N'Diana: Her True Story', '19920706')
,(N'Kathryn Stockett', N'The Help', '20090111')
,(N'Joseph Heller', N'Catch-22', '19610710')
,(N'Albert Camus', N'The Stranger (L''Étranger)', '19420625')
,(N'Ken Follett', N'Eye of the Needle', '19780917')
,(N'Alice Sebold', N'The Lovely Bones', '20020406')
,(N'Jung Chang', N'Wild Swans', '19921022')
,(N'Tomás Eloy Martínez', N'Santa Evita', '19950826')
,(N'Elie Wiesel', N'Night (Un di Velt Hot Geshvign)', '19580204')
,(N'Yu Dan', N'Confucius from the Heart', '20061005')
,(N'Marabel Morgan', N'The Total Woman', '19740516')
,(N'Taichi Sakaiya', N'Knowledge-value Revolution', '19850809')
,(N'Xue Muqiao', N'Problems in China''s Socialist Economy', '19790727')
,(N'Richard Nelson Bolles', N'What Color Is Your Parachute?', '19700309')
,(N'Pierre Dukan', N'The Dukan Diet', '20000721')
,(N'Alex Comfort', N'The Joy of Sex', '19720915')
,(N'Robert L. Short', N'The Gospel According to Peanuts', '19650311')
,(N'Mark Manson', N'The Subtle Art of Not Giving a Fuck', '20160118')
,(N'Yann Martel', N'Life of Pi', '20010725')
,(N'Lois Lowry', N'The Giver', '19930516')
,(N'Patricia Nell Warren', N'The Front Runner', '19740824')
,(N'Eliyahu M. Goldratt', N'The Goal', '19840925')
,(N'Ray Bradbury', N'Fahrenheit 451', '19530916')
,(N'Frank McCourt', N'Angela''s Ashes', '19960706')
,(N'Mohandas Karamchand Gandhi', N'The Story of My Experiments with Truth (સત્યના પ્રયોગો અથવા આત્મકથા)', '19250722')
,(N'Helen Fielding', N'Bridget Jones''s Diary', '19960619')
,(N'J. K. Rowling', N'Harry Potter', '19970223')
,(N'R. L. Stine', N'Goosebumps', '19920513')
,(N'Erle Stanley Gardner', N'Perry Mason', '19330527')
,(N'Stan and Jan Berenstain', N'Berenstain Bears', '19620814')
,(N'Various authors', N'Choose Your Own Adventure', '19790216')
,(N'Jeff Kinney', N'Diary of a Wimpy Kid', '20070213')
,(N'Francine Pascal and ghostwriters', N'Sweet Valley High', '19830418')
,(N'Rev. W. Awdry, Christopher Awdry', N'The Railway Series', '19450509')
,(N'Enid Blyton', N'Noddy', '19490506')
,(N'Various authors as Carolyn Keene', N'Nancy Drew', '19301015')
,(N'Frédéric Dard', N'San-Antonio', '19490216')
,(N'Dan Brown', N'Robert Langdon', '20001119')
,(N'Elisabetta Dami', N'Geronimo Stilton', '19970501')
,(N'Rick Riordan', N'Percy Jackson & the Olympians', '20050108')
,(N'Ann Martin', N'The Baby-sitters Club', '19860915')
,(N'Stephenie Meyer', N'Twilight', '20050403')
,(N'Various authors', N'Star Wars', '19771022')
,(N'Mercer Mayer', N'Little Critter', '19750215')
,(N'Beatrix Potter', N'Peter Rabbit', '19021010')
,(N'E. L. James', N'Fifty Shades', '20110910')
,(N'Various authors', N'American Girl', '19860513')
,(N'Jack Canfield, Mark Victor Hansen', N'Chicken Soup for the Soul', '19971106')
,(N'Norman Bridwell', N'Clifford the Big Red Dog', '19630802')
,(N'Gilbert Patten', N'Frank Merriwell', '18960218')
,(N'Clive Cussler', N'Dirk Pitt', '19730624')
,(N'Eiji Yoshikawa', N'Musashi', '19350527')
,(N'C. S. Lewis', N'The Chronicles of Narnia', '19500717')
,(N'Roger Hargreaves, Adam Hargreaves', N'Mr. Men', '19710503')
,(N'Gérard de Villiers', N'SAS', '19651108')
,(N'Suzanne Collins', N'The Hunger Games trilogy', '20080613')
,(N'Ian Fleming', N'James Bond', '19530525')
,(N'Gilbert Delahaye, Marcel Marlier', N'Martine', '19540410')
,(N'Stieg Larsson, David Lagercrantz', N'Millennium', '20050508')
,(N'George R. R. Martin', N'A Song of Ice and Fire', '19960123')
,(N'Robert Jordan, Brandon Sanderson', N'The Wheel of Time', '19900527')
,(N'Terry Pratchett', N'Discworld', '19830115')
,(N'Dick Bruna', N'Nijntje (Miffy)', '19550520')
,(N'James Patterson', N'Alex Cross', '19930807')
,(N'Takashi Yanase', N'Anpanman', '19730920')
,(N'Dav Pilkey', N'Captain Underpants', '19970408')
,(N'R. L. Stine', N'Fear Street', '19890414')
,(N'Astrid Lindgren', N'Pippi Långstrump (Pippi Longstocking)', '19450101')
,(N'Anne Rice', N'The Vampire Chronicles', '19760508')
,(N'Jean Bruce', N'OSS 117', '19491106')
,(N'A. A. Milne; illustrated by E. H. Shepard', N'Winnie-the-Pooh', '19260309')
,(N'Mary Pope Osborne', N'Magic Tree House series', '19920623')
,(N'Tim LaHaye, Jerry B. Jenkins', N'Left Behind', '19961005')
,(N'Lemony Snicket aka Daniel Handler', N'A Series of Unfortunate Events', '19991114')
,(N'Laura Ingalls Wilder', N'Little House on the Prairie', '19320219')
,(N'Alf Wight, as James Herriot', N'All Creatures Great and Small', '19700217')
,(N'Lee Child', N'Jack Reacher', '19970420')
,(N'Joanna Cole, illustrated by Bruce Degen', N'The Magic School Bus', '19860906')
,(N'Martin Handford', N'Where''s Wally?[223]', '19870227')
,(N'John Gray', N'Men Are from Mars, Women Are from Venus', '19920113')
,(N'Various authors as Franklin W. Dixon', N'The Hardy Boys', '19270705')
,(N'Various authors as Laura Lee Hope', N'The Bobbsey Twins', '19040301')
,(N'Edgar Rice Burroughs', N'Tarzan', '19140719')
,(N'Jean M. Auel', N'Earth''s Children', '19800708')
,(N'Various authors', N'A Child''s First Library Of Learning', '19800121')
,(N'Barbara Park', N'Junie B. Jones', '19920517')
,(N'Michael Connelly', N'Harry Bosch', '19920419')
,(N'Jo Nesbø', N'Harry Hole', '19970405')
,(N'Erin Hunter', N'Warriors', '20030616')
,(N'original author: Liu Zhixia', N'Picture-and-story book Railway Guerilla', '19550620')
,(N'Cassandra Clare', N'The Shadowhunter Chronicles', '20070820')
,(N'Yutaka Hara', N'Kaiketsu Zorori', '19870315')
,(N'Michael Bond', N'Paddington Bear', '19581025')
,(N'Veronica Roth', N'Divergent trilogy', '20110820')
,(N'Sachiko Kiyono', N'Nontan', '19761019')
,(N'Christopher Paolini', N'The Inheritance Cycle', '20020524')
,(N'Robert Kiyosaki, Sharon Lechter', N'Rich Dad, Poor Dad', '19971002')
,(N'Kazuma Kamachi', N'Toaru Majutsu no Index', '20040606')
,(N'Kaoru Kurimoto', N'グイン・サーガ (Guin Saga)', '19790124')
,(N'Sōhachi Yamaoka', N'徳川家康 (Tokugawa Ieyasu)', '19500427')
,(N'Beverly Cleary', N'Ramona', '19550907')
,(N'Stephen King', N'The Dark Tower', '19821106')
,(N'Rachel Renée Russell', N'Dork Diaries', '20090214')
,(N'Warren Murphy and Richard Sapir, various authors', N'The Destroyer', '19710223')
,(N'Hans Augusto Rey and Margret Rey', N'Curious George', '19410715')
,(N'Terry Brooks', N'Shannara', '19770324')
,(N'Henning Mankell', N'Kurt Wallander', '19910705')
,(N'Margit Sandemo', N'Sagan om Isfolket (The Legend of the Ice People)', '19820216')
,(N'Terry Goodkind', N'The Sword of Truth', '19981104')
,(N'Diana Gabaldon', N'Outlander', '19911123')
,(N'Masamoto Nasu', N'ズッコケ三人組 (Zukkoke Sanningumi)', '19780215')
,(N'Shōtarō Ikenami', N'鬼平犯科帳 (Onihei Hankachō)', '19681120')
,(N'Various authors', N'Brain Quest', '19920103')
,(N'Arthur Agatston', N'South Beach Diet', '20030701')
,(N'Reki Kawahara', N'ソードアート・オンライン (Sword Art Online)', '20090513')
,(N'Ryōtarō Shiba', N'竜馬がゆく (Ryoma ga Yuku)', '19630125')
,(N'Eoin Colfer', N'Artemis Fowl', '20010525')
,(N'Lauren Tarshis', N'I Survived', '20100710')
,(N'Various authors', N'Découvertes Gallimard', '19860927')
,(N'Brian Jacques', N'Redwall', '19861116')
,(N'Lucy Cousins', N'Maisy', '19900109')
,(N'Various authors', N'Dragonlance', '19840516')
,(N'Kazumasa Hirai', N'幻魔大戦 (Genma Taisen)', '19790627')
,(N'Hiroyuki Itsuki', N'青春の門 (The Gate of Youth)', '19700425')
,(N'Hajime Kanzaka', N'スレイヤーズ (Slayers)', '19891110')
,(N'Isaac Asimov', N'The Foundation Trilogy', '19500720')
,(N'Terry Deary', N'Horrible Histories', '19930914')
,(N'Daisy Meadows', N'Rainbow Magic', '20030127')
,(N'Louis Masterson', N'Morgan Kane', '19660410')
,(N'Charlaine Harris', N'The Southern Vampire Mysteries', '20010421')
,(N'Lester Dent, various authors', N'Doc Savage', '19331115')
,(N'Nagaru Tanigawa', N'涼宮ハルヒシリーズ (Haruhi Suzumiya Series)', '20030818')
,(N'Various authors', N'科学のアルバム (Kagaku no album)', '19700211')
,(N'Shotaro Ikenami', N'剣客商売 (Kenkaku Shobai)', '19720913')
,(N'Boris Akunin', N'Erast Fandorin series', '19980517')
,(N'Anne McCaffrey', N'Dragonriders of Pern', '19670715')
,(N'Hideyuki Kikuchi', N'吸血鬼ハンターD (Vampire Hunter D)', '19830908')
,(N'Douglas Adams, plus a final book by Eoin Colfer', N'The Hitchhiker''s Guide to the Galaxy', '19791123')
,(N'Osamu Soda', N'ぼくらシリーズ (Bokura series)', '19850607')
,(N'Helen Fielding', N'Bridget Jones', '19960407')
,(N'Philip Pullman', N'His Dark Materials', '19951022')
,(N'Yoshiki Tanaka', N'銀河英雄伝説 (Legend of the Galactic Heroes)', '19821103')
,(N'Alexander McCall Smith', N'The No. 1 Ladies Detective Agency', '19990926')
,(N'Marcus Pfister', N'Der Regenbogenfisch (Rainbow Fish)', '19921124')
,(N'Raymond E. Feist', N'The Riftwar Cycle', '19820710')
,(N'Andrzej Sapkowski', N'Wiedźmin (The Witcher)', '19900419')

USE [BookStoreDb]
GO
CREATE LOGIN Tims WITH PASSWORD = 'LightningBolt1'
GO
Use [BookStoreDb];
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'Tims')
BEGIN
    CREATE USER Tims FOR LOGIN Tims
    EXEC sp_addrolemember N'db_owner', N'Tims'
END;
GO
```

### EF Scripts (right now not required, only initial  migration exists)

Database scaffolding:
```
dotnet ef dbcontext scaffold "Server=.;Database=BookStoreDb;User Id=Tims;Password=LightningBolt1;" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data
```
or:
```
dotnet ef dbcontext scaffold Name=ConnectionStrings:BookStoreDatabase  Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data
```
