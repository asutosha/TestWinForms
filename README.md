# TestWinForms
getting to grips with the VS designer

In this solution i am trying to create a form that responds to some dynamic text data that i wish to display.
Here's the basic lay-out i am ultimately seeking:

	--------------------------------------------------
	|     fixed-size form header        |            | 
	------------------------------------|   side     |
	|                                   |   panel    |
	|      dynamic content panel        |   stuff    |
	|                                   |            |
	--------------------------------------------------
	|            fixed-size form trailer             |               
	--------------------------------------------------

i want the form to:
+ not be resizable by the user
+ respond to the dynamic content by:
  + shrinking as small as possible down to a pre-determined minimum form-size.
  + growing up to a pre-determined a maximum form-size; and providing appropriate scroll-bars on the dynamic content panel thereafter

That's all.
