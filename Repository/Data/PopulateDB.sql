use [blisspolldb]

insert into Polls values ('http://teste.com/image1.jpg', 'http://teste.com/thumb1.jpg', 'Who is the best F1 driver of all time?', GETDATE())
insert into Polls values ('http://teste.com/image2.jpg', 'http://teste.com/thumb2.jpg', 'Which language do you prefer to work?', GETDATE())
insert into Polls values ('http://teste.com/image3.jpg', 'http://teste.com/thumb3.jpg', 'Who is the strongest super-hero?', GETDATE())
insert into Polls values ('http://teste.com/image4.jpg', 'http://teste.com/thumb4.jpg', 'Which is the tastiest?', GETDATE())
insert into Polls values ('http://teste.com/image5.jpg', 'http://teste.com/thumb5.jpg', 'Who is the best football player of all time?', GETDATE())
insert into Polls values ('http://teste.com/image6.jpg', 'http://teste.com/thumb6.jpg', 'What colour do you prefer?', GETDATE())
insert into Polls values ('http://teste.com/image7.jpg', 'http://teste.com/thumb7.jpg', 'What car type do you prefer?', GETDATE())
insert into Polls values ('http://teste.com/image8.jpg', 'http://teste.com/thumb8.jpg', 'Who is the best actor of all time?', GETDATE())
insert into Polls values ('http://teste.com/image9.jpg', 'http://teste.com/thumb9.jpg', 'Who is the best actress of all time?', GETDATE())
insert into Polls values ('http://teste.com/image10.jpg', 'http://teste.com/thumb10.jpg', 'What city is most warm?', GETDATE())
insert into Polls values ('http://teste.com/image11.jpg', 'http://teste.com/thumb11.jpg', 'What is the most beautiful city in Brazil?', GETDATE())
insert into Polls values ('http://teste.com/image12.jpg', 'http://teste.com/thumb12.jpg', 'What is the best place to live in Europe?', GETDATE())
insert into Polls values ('http://teste.com/image13.jpg', 'http://teste.com/thumb13.jpg', 'What is the best place to live in North America?', GETDATE())
insert into Polls values ('http://teste.com/image14.jpg', 'http://teste.com/thumb14.jpg', 'What is the best place to live in South America?', GETDATE())
insert into Polls values ('http://teste.com/image15.jpg', 'http://teste.com/thumb15.jpg', 'What is the best place to live in Africa?', GETDATE())
insert into Polls values ('http://teste.com/image16.jpg', 'http://teste.com/thumb16.jpg', 'What is the best place to live in Oceania?', GETDATE())
insert into Polls values ('http://teste.com/image17.jpg', 'http://teste.com/thumb17.jpg', 'What is the best place to live in Portugal?', GETDATE())
insert into Polls values ('http://teste.com/image18.jpg', 'http://teste.com/thumb18.jpg', 'Which on is more expensive?', GETDATE())
insert into Polls values ('http://teste.com/image19.jpg', 'http://teste.com/thumb19.jpg', 'What is the coldest place of the world?', GETDATE())
insert into Polls values ('http://teste.com/image20.jpg', 'http://teste.com/thumb20.jpg', 'What is the best video game console of all time?', GETDATE())
insert into Polls values ('http://teste.com/image21.jpg', 'http://teste.com/thumb21.jpg', 'What is the best video game of all time?', GETDATE())


insert into Choices values ('Ayrton Senna', 10 ,(select p.Id from Polls p where p.Question = 'Who is the best F1 driver of all time?'))
insert into Choices values ('Lewis Hamilton', 9 ,(select p.Id from Polls p where p.Question = 'Who is the best F1 driver of all time?'))

insert into Choices values ('C#', 20 ,(select p.Id from Polls p where p.Question = 'Which language do you prefer to work?'))
insert into Choices values ('Python', 15 ,(select p.Id from Polls p where p.Question = 'Which language do you prefer to work?'))
insert into Choices values ('VB.NET', 25 ,(select p.Id from Polls p where p.Question = 'Which language do you prefer to work?'))

insert into Choices values ('Superman', 25 ,(select p.Id from Polls p where p.Question = 'Who is the strongest super-hero?'))
insert into Choices values ('Hulk', 22 ,(select p.Id from Polls p where p.Question = 'Who is the strongest super-hero?'))

insert into Choices values ('Pizza', 21 ,(select p.Id from Polls p where p.Question = 'Which is the tastiest?'))
insert into Choices values ('BBQ', 25 ,(select p.Id from Polls p where p.Question = 'Which is the tastiest?'))

insert into Choices values ('Maradona', 25 ,(select p.Id from Polls p where p.Question = 'Who is the best football player of all time?'))
insert into Choices values ('Pelé', 100 ,(select p.Id from Polls p where p.Question = 'Who is the best football player of all time?'))

insert into Choices values ('Green', 50 ,(select p.Id from Polls p where p.Question = 'What colour do you prefer?'))
insert into Choices values ('Blue', 55 ,(select p.Id from Polls p where p.Question = 'What colour do you prefer?'))

insert into Choices values ('SUV', 55 ,(select p.Id from Polls p where p.Question = 'What car type do you prefer?'))
insert into Choices values ('Sedan', 55 ,(select p.Id from Polls p where p.Question = 'What car type do you prefer?'))

insert into Choices values ('Tom Hanks', 32 ,(select p.Id from Polls p where p.Question = 'Who is the best actor of all time?'))
insert into Choices values ('Harrison Ford', 41 ,(select p.Id from Polls p where p.Question = 'Who is the best actor of all time?'))
insert into Choices values ('Tony Ramos', 62 ,(select p.Id from Polls p where p.Question = 'Who is the best actor of all time?'))

insert into Choices values ('Fernanda Montenegro', 99 ,(select p.Id from Polls p where p.Question = 'Who is the best actress of all time?'))
insert into Choices values ('Susan Sarandon', 45 ,(select p.Id from Polls p where p.Question = 'Who is the best actress of all time?'))
insert into Choices values ('Michelle Pfeiffer', 41 ,(select p.Id from Polls p where p.Question = 'Who is the best actress of all time?'))

insert into Choices values ('Rio de Janeiro', 78 ,(select p.Id from Polls p where p.Question = 'What city is most warm?'))
insert into Choices values ('Bogotá', 40 ,(select p.Id from Polls p where p.Question = 'What city is most warm?'))

insert into Choices values ('Natal', 88 ,(select p.Id from Polls p where p.Question = 'What is the most beautiful city in Brazil?'))
insert into Choices values ('Florianópolis', 82 ,(select p.Id from Polls p where p.Question = 'What is the most beautiful city in Brazil?'))

insert into Choices values ('Lisboa', 99 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Europe?'))
insert into Choices values ('Porto', 98 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Europe?'))

insert into Choices values ('Calgary', 98 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in North America?'))
insert into Choices values ('New York', 80 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in North America?'))

insert into Choices values ('Buenos Aires', 77 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in South America?'))
insert into Choices values ('Montevidéu', 89 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in South America?'))

insert into Choices values ('Lagos', 34 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Africa?'))
insert into Choices values ('Cape Town', 75 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Africa?'))

insert into Choices values ('New Zealand', 75 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Oceania?'))
insert into Choices values ('Australia', 60 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Oceania?'))

insert into Choices values ('Lisboa', 68 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Portugal?'))
insert into Choices values ('Algarve', 79 ,(select p.Id from Polls p where p.Question = 'What is the best place to live in Portugal?'))

insert into Choices values ('Ferrari', 79 ,(select p.Id from Polls p where p.Question = 'Which on is more expensive?'))
insert into Choices values ('IPhone 13 Pro', 99 ,(select p.Id from Polls p where p.Question = 'Which on is more expensive?'))

insert into Choices values ('Syberia', 99 ,(select p.Id from Polls p where p.Question = 'What is the coldest place of the world?'))
insert into Choices values ('Canada', 98 ,(select p.Id from Polls p where p.Question = 'What is the coldest place of the world?'))

insert into Choices values ('Atari', 98 ,(select p.Id from Polls p where p.Question = 'What is the best video game console of all time?'))
insert into Choices values ('Playstation 2', 110,(select p.Id from Polls p where p.Question = 'What is the best video game console of all time?'))
insert into Choices values ('XBox 360', 100,(select p.Id from Polls p where p.Question = 'What is the best video game console of all time?'))

insert into Choices values ('The Last Of Us', 100,(select p.Id from Polls p where p.Question = 'What is the best video game of all time?'))
insert into Choices values ('Pac-Man', 101,(select p.Id from Polls p where p.Question = 'What is the best video game of all time?'))