# Starting-out-with-Visual-C

Book Guide

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
</ul>

</br>
<b>The following are commands learned as I progress throught the book.</b>
</br>
<ul>
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
</ul>
