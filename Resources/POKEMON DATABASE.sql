Create Database Pokemon
go

use Pokemon
go

drop table if exists Stats
go

Create table Stats
(
	ID int NOT NULL,
	Name varchar(40) NOT NULL,
	Type varchar(40) NOT NULL,
	Type2 varchar(40),
	HP smallint NOT NULL,
	ATK smallint NOT NULL,
	DEF smallint NOT NULL,
	SPA smallint NOT NULL,
	SPDE smallint NOT NULL,
	SPD smallint NOT NULL,
	Ability varchar(40) NOT NULL,
	Ability2 varchar(40),
)

Bulk insert Stats
From 'C:\Users\CarterS\Downloads\Pokemon - Stats.csv'
with
(
FIRSTROW = 1, --Second row if header row in file
FIELDTERMINATOR = ',',  --CSV field delimiter
ROWTERMINATOR = '\n',   --Use to shift the control to next row
TABLOCK
)

go

Select *
from Stats
--where ID in ('252')
go

