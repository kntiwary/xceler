# xceler




* Project name: xceler
* Description: This  mobile app has been Implemented using Xamarin Forms(PCL). The App consist of three screen (MasterDetails)Descriptions are as mentioned below:-

1.)Fill Details - This Screen has filed like         FirstName,LastName,
DOB,Country-Populated using API,Sex etc
2.)ViewLocalDetail- This screen consist of the all the details added, which is stored locally using SQLite
3.)JsonList- This screen has list of user data from External source(List View Implementation)

 
* API’s:
* 1.) http://coronis.interactivedns.com/api/GP  Implemented in screen three to fetch list of user details.
* 2.http://test.coronis.interactivedns.com/api/Countries Imlemented in the FillDetail screen to get list of Countries




* Nuget: NewtonsoftJson ——WebServices, SQLite-net-Pcl —-Locat Database Implementation

* Folders:- WebServ—Webservices, DALSQLite-Database/SQLite,Services-HambermenuList, customControls



* Design: The Design Pattern used is MVVM.
