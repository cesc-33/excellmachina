# excellmachina
This is a project I created out of interest. The origin of this project is from the time when I was an intern and was supposed to create a program with VBA that allows the User to operate on the Excel file with an "Userform". This C# project is supposed to be an attempt at a remake of the original program.

It still has some bugs and some features will be added over time.

	Known bugs:
	-a few code parts need to be surrounded by a try-catch statement
	-after searching for a value, an error message appears during sheet selection

	Missing functions:
	-The search function should include that you can find the next or previous value by pressing a button.
	-Values in the cells can not be edited
	-Cells are not displayed true to original (missing color and formation)
	-Create copy of original workbook and if user clicks "CANCEL BUTTON" delete workbook and change copy to original name.

	Upcoming features:
	-Open the last edited file
	-Option to add a sheet instead of reloading it
	-columns and rows need an ID like in Excel
	-Dark Mode switch
	-Localization
	
The Forms and updated Forms:

The Main Form

![Screenshot 2023-03-28 030128](https://user-images.githubusercontent.com/112399284/228099800-b83d7e5e-446b-465b-9aec-ae1a92cd49f3.png)
![mainform](https://user-images.githubusercontent.com/112399284/232918923-488199cd-bb56-4931-96d7-64a69aa032a1.png)


The Main Form search and edit Value Mode

![Screenshot 2023-03-28 030839](https://user-images.githubusercontent.com/112399284/228100445-47623d6a-b701-448f-8ac0-d70b016761ec.png)
![mainformdelarea](https://user-images.githubusercontent.com/112399284/232919060-806679b8-3ae0-4cb7-962c-dee9420093b9.png)
![mainformsearchval](https://user-images.githubusercontent.com/112399284/232919080-c40aabfa-cef7-420e-a4db-2892ccccb0c1.png)


Uploading a Excel Workbook

![Screenshot 2023-03-28 030204](https://user-images.githubusercontent.com/112399284/228099982-74f4e63a-9235-41d3-b948-8ceb3ebedcdb.png)
![importform](https://user-images.githubusercontent.com/112399284/232919143-3cfc9b91-66bb-4f72-94ea-df11c91a17b9.png)


Search and edit Value

![Screenshot 2023-03-28 030232](https://user-images.githubusercontent.com/112399284/228100073-ec563245-d1ed-4fdd-8a45-dd4259e2a240.png)
![editvalform](https://user-images.githubusercontent.com/112399284/232919177-b8130b80-5382-4c4d-ab60-1eb38f039a2e.png)


Enter Sheet name

![Screenshot 2023-03-28 030253](https://user-images.githubusercontent.com/112399284/228100147-95c55dc7-d617-4136-a031-4d8588f8180d.png)
![inputdialogform](https://user-images.githubusercontent.com/112399284/232919212-1f3aff02-9c07-4413-868b-ce796eec6a14.png)


This Application is able to upload a Excel Workbook, display the used Range of every sheet on the DataGridView. Show if the selected sheet has a certain protection and enable or disable it. It has also the options to copy, delete, move and create templates of existing sheets. As mentioned before, more features will follow.
