﻿# Starting-out-with-Visual-C
![Book Image](Images/BookImage.jpg?raw=true "Title")
</br>
Starting out with visual C# <b>Book Guide</b>

<u><b>The following are notes that I will be taking as I progress to
throught the book:</b></u>
</br>

<ul>
	<li><b>Event handlers</b> respond to specific events that take place while an 
	application is running.</li>
	<li>When you have a project open in Visual Studio, the time during which you build the GUI
	and write the application’s code is referred to as design time. The time during which an 
	application is executing is referred to as run time. </li>
	<li>A <b>Label control</b> displays text on a form. Label controls have various
	properties that affect the control’s appearance. Label controls can be used
	to display unchanging text, or program output.</li>
    <li>
        A jagged array is similar to a two-dimensional array, but the rows in a jagged array can have different lengths.
    </li>
    <li>
        C# allows you to access the individual characters in a string using <b><i>subscript</i></b> notation. You use subscript 0 to access the first character, subscript 1 to access the second character, and so forth. The subscript of the last character is 1 less than the string’s length. 
    </li>
    <li>
        An enumerated data type is a data type that you can create. When you create an enumerated data type, you specify a set of symbolic values that belong to that data type. 
        Here is an example of an enumerated data type declaration:
        </br>
        <b><i>enum</i></b> Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    </li>
    <li>
        The <b><i>ImageList</i></b> control allows you to store a collection of images. At run
        time, you can retrieve an image from an ImageList control and display it in
        a PictureBox control.
        <li> Image List Guidelines
		<ul>
			<li>
                All the images stored in an ImageList control should be the same size.
			</li>
            <li>
                The images stored in an ImageList control can be no more than 256 by 256 pixels
                in size.			
            </li>
            <li>
                All the images stored in an ImageList control should be in the same format 
                (.bmp, .jpg, etc.)			
            </li>
		</ul>
    </li>
	<li>
		<b><i>MessageBox.Show("String goes here")</i></b>: Displays a pop up message after a 
		control is triggered.
	</li>
	<li>
		To close an application’s form in code, you use the statement <b><i>this.Close();</i></b>
	</li>
	<li>
		The <b><i>TextBox control</i></b> is a rectangular area that can accept keyboard input
		from the user.
	</li>
	<li>	Formating Strings
		<ul>
			<li>
				When you pass the formatting string <b><i>"c"</i></b> to the <b><i>ToString</i></b> method, the number is
				returned formatted as currency.
			</li>
			<li>
				<b><i>Number format</i></b> ("n" or "N") displays numeric values with comma separators and a decimal point. By default, 
				two digits display to the right of the decimal point. Negative values are displayed with a leading minus sign. 
				An example is <b><i>−2,345.67</i></b>.
			</li>
			<li>
				<b><i>Exponential format</i></b> ("e" or "E") displays numeric values in scientific notation. The number
				is displayed with a single digit to the left of the decimal point. The letter e appears in front
				of the exponent, and the exponent has a leading + or + sign. By default, six digits display to
				the right of the decimal point, and a leading minus sign is used if the number is negative.
				An example is <b><i>−2.345670e+003</i></b>.
			</li>
			<li>
				<b><i>Percent format</i></b> ("p" or "P") causes the number to be multiplied by 100 and displayed with
				a trailing space and % sign. By default, two digits display to the right of the decimal point.
				Negative values are displayed with a leading minus sign. For example, the number 0.125
				would be formatted as <b><i>12.5 %</i></b> and the number −0.2345 would be formatted as <b><i>−23.45 %</i></b>.
			</li>
		</ul>
	 </li>
	 <li>
		<b><i>A field</i></b> is a variable that is declared at the class level. A field’s scope is the entire class.
	 </li>
	 <li>
		Users want to tab smoothly from one control to the next, in a logical sequence. You can
		modify the tab order by changing a control’s <b><i>TabIndex property</i></b>. The TabIndex property
		contains a numeric value, which indicates the control’s position in the tab order.
	</li>
	<li>
		Exceptions should be prevented when possible. You can use the <b><i>TryParse</i></b> methods to prevent exceptions as a 
		result of the user entering invalid data.
	</li>
	<li>
		The <b><i>OpenFileDialog</i></b> and <b><i>SaveFileDialog</i></b> controls allow your application to display standard Windows dialog 
		boxes for opening and saving files. These allow the user to easily specify a file’s name and location.
	</li>
    <li> The <b><i>foreach Loop</i></b> versus the <b><i>for Loop</i></b>.
        <ul>
            <li>
                When you need to read the values that are stored in an array from the first element to the
                last element, the foreach loop is simpler to use than the for loop. With the foreach
                loop, you do not have to be concerned about the size of the array, and you do not have to
                create a counter variable to hold subscripts; however, because the iteration variable is
                read only, there are circumstances in which the foreach loop is not adequate. You cannot
                use the foreach loop if you need to do any of the following:
                <ul>
                    <li>
                        Change the contents of an array element.
                    </li>
                    <li>
                        Access some, but not all, of the array elements
                    </li>
                    <li>
                        Work through the array elements in reverse order.
                    </li>
                    <li>
                        Simultaneously work with two or more arrays within the loop.
                    </li>
                </ul>
            </li>
        </ul>
    </li>
    <li>
        The <b><i>accessors</i></b> allow code outside the class to get the property’s value and assign values to the property.
    </li>
    <li>
        A form can be either <b><i>modal</i></b> or <b><i>modeless</i></b>. The ShowDialog method displays a form in
        modal fashion. When a modal form is displayed, no other form in the application can
        receive the focus until the modal form is closed. The user must close the modal form
        before he or she can work with any other form in the application. A modeless form, on
        the other hand, allows the user to switch focus to another form while it is displayed. 
        <ul>
            <li>
                When you call the ShowDialog method to display a modal form, control of the program is transferred to the form, and no statements appearing after the ShowDialog method call will execute until the form is closed.
            </li>
            <li>
                When you call the Show method to display a modeless form, however, the statements that appear after the Show method call continue to execute while the form is displayed. The application does not wait until the modeless form is closed before executing these statements.
            </li>
            <li>
                Modeless forms are typically used in special situations. In most multiform applications, you will want to display forms in modal fashion.
            </li>
        </ul>
    </li>
    <li>
        Summary of Constructor Issues in <b><i>Inheritance</i></b>
        <ul>
            <li>
                When you create an instance of a derived class, the base class constructor is executed
                first and then the derived class constructor is executed.
            </li>
            <li>
                When you create an instance of a derived class, by default the base class’s parameterless constructor is    automatically executed.
            </li>
            <li>
                If you want a parameterized constructor in the base class to execute, you must explicitly call it from the derived class’s constructor. You do this by writing the notation : base(parameterList) in the derived class’s constructor header.
            </li>
                If the base class does not have a parameterless constructor, the derived class constructor must use the notation : base(parameterList) to call one of the base class’s parameterized constructors.
            </li>
        </ul>
    </li>
    <li>
        <b><i>Polymorphism</i></b> allows derived classes to have methods with the same names as methods in their base classes. It gives the ability for a program to call the correct method, depending on the type of object that is used to call it.
        <ul>
            <li>
                The ability to define a method in a base class and then define a method with the
                same name in a derived class. When a derived class method has the same name as a
                base class method, it is often said that the derived class method overrides the base
                class method.
            </li>
            <li>
                The ability to call the correct version of an overridden method, depending on the
                type of object that is used to call it. If a derived class object is used to call an overridden method, then the derived class’s version of the method is the one that executes. If a base class object is used to call an overridden method, then the base class’s version of the method is the one that executes.
            </li>
        </ul>
    </li>
    <li>
        The primary difference between an abstract class and a regular class (which is sometimes
        called a concrete class) is that the abstract class cannot be instantiated. A statement that
        tries to use the new operator to instantiate an abstract class will not compile.
    </li>
    <li>
        <b><i>Databases</i></b>
        <ul>
            <li>
                When you use Visual Studio to create a database, as you did in Tutorial 11-1, the database file will be created in the project folder.
            </li>
            <li>
                When you create an SQL Server database, you will also see a file that ends with the .LDF extension. For example, in Figure 11-23 you see a file named Phonelist_
                log.LDF. This is a transaction log file. The SQL Server DBMS uses it to keep a log of all the operations that you perform on the database.
            </li>
        </ul>
    </li>
    <li>
        <b><i>DataGridView</i></b>
        <ul>
            <li>
                A <b><i>DataGridView</i></b> control can display a database table in a scrollable grid.
            </li>
            <li>
                A <b><i>data-bound</i></b> control is a user interface control that is connected to a data source. For
                example, a data-bound control can be connected to a column in a database table.
            </li>
             <li>
               A <b><i>DataGridView</i></b> control can display an entire database table in a scrollable grid on an application’s form.
            </li>
            <li>
                DataGridView Controls
                <ul>
                    <li>
                        <i>personTableAdapter</i>—This is the table adapter. It gets data directly from the data source, which in this case is the Person.mdf database.
                    </li>
                    <li>
                        <i>tableAdapterManager</i>—In many applications, the database has multiple tables from which we want to get data. A table adapter manager is a component that manages multiple tables.
                    </li>
                    <li>
                        <i>personDataSet</i>—This is the dataset component. It gets a copy of the table from the table adapter and keeps it in memory. The application works with the dataset instead of working directly with the database.
                    </li>
                    <li>
                        <i>personBindingSource</i>—This is the navigation bar.
                    </li>
                </ul>
            </li>
        </ul>
    </li>
</ul>
