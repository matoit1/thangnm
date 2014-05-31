Create Database HaMy
On( Name = HaMy,
FileName = 'D:\HaMy_Data.mdf',
Size = 5MB,
Maxsize=UNLIMITED,
FileGrowth = 10%)
Log On( Name = HaMy_Log,
FileName = 'D:\HaMy_Log.ldf',
Size = 2MB,
Maxsize=UNLIMITED,
FileGrowth = 10%)