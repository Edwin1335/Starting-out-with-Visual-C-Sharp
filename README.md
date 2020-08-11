# Starting-out-with-Viusal-C#
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
</ul>

</br>
<b>The following are commands learned as i progress throught the book.</b>
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
</ul>
