-- Resetting the Auto inc. to 1 in case there were some values before in the table.
ALTER TABLE `Books` AUTO_INCREMENT = 1;
INSERT INTO `VPLibrary`.`Books` (`Book_name`, `Auth_name`, `Auth_surname`, `Publish_year`, `Publish_house`, `Book_description`) VALUES 
-- Book1
('A Game of Thrones', 'George ', 'R.R. Martin', 1996, 'Bantam Spectra', 
'The first installment of the Song of Ice and Fire series. 
Following the story of multiple viewpoint characters that delve into the fantasy world created by 
GRRM. 
It follows three main storylines: The Seven Kingdoms, The Wall and The Far East.'),
-- Book2
  ('A Clash of Kings', 'George ', 'R.R. Martin', 1998, 'Bantam Spectra', 
'A Clash of Kings depicts the Seven Kingdoms of Westeros in civil war,
 while the Night''s Watch mounts a reconnaissance to investigate the mysterious people
  known as wildlings. Meanwhile Daenerys Targaryen 
  continues her plan to reconquer the Seven Kingdoms.'),
-- Book3
  ('A Storm of Swords', 'George ', 'R.R. Martin', 2000, 'Bantam Spectra', 
'A Storm of Swords picks up the story slightly before the end of its predecessor, A Clash of Kings. 
The Seven Kingdoms of Westeros are still in the grip of the War of the Five Kings, 
wherein Robb Stark, Balon Greyjoy, Joffrey Baratheon, and Stannis Baratheon compete for the 
Iron Throne. Meanwhile, a large host of wildlings approach the Wall under the leadership
 of Mance Rayder, the self-proclaimed "King Beyond the Wall", with only the undermanned Night''s
  Watch in opposition. Finally, Daenerys Targaryen approaches Pentos.'),
-- Book4
  ('A Feast for Crows', 'George ', 'R.R. Martin', 2005, 'Bantam Spectra', 
'The War of the Five Kings is slowly coming to its end. Stannis Baratheon has gone to the aid of
 the Wall, where Jon Snow has become the 998th Lord Commander of the Night''s Watch. 
 King Tommen Baratheon, Joffrey''s eight-year-old brother, now rules in King''s Landing under his 
 mother, Cersei Lannister. Brienne, the Maid of Tarth, is on a mission to find Sansa Stark,
  aided by Jaime Lannister. Sansa Stark is hiding in the Vale, protected by Petyr Baelish, 
  who has murdered his wife Lysa Arryn and named himself Protector of the
   Vale and guardian of eight-year-old Lord Robert Arryn.'),
-- Book5
  ('A Dance with Dragons', 'George ', 'R.R. Martin',2011, 'Bantam Spectra', 
'A Dance with Dragons picks up where A Storm of Swords leaves off and runs simultaneously
 with events in A Feast for Crows. The War of the Five Kings seems to be winding down. 
 In the North, King Stannis Baratheon has installed himself at the Wall and vowed to win the 
 support of the northmen to continue his struggle to claim the Iron Throne, although this is 
 complicated by the fact that much of the west coast is under occupation by the ironborn.');
 