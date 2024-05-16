**Trackgenda User Guide**

**What is Trackgenda?**

Trackgenda is an application designed to redefine calendar management
with its superior features and intuitive interface. It is built using C#
.NET Framework using Windows Forms, MySQL, XAMPP phpMyAdmin, and many
API's.

**Installing Software**

To run Trackgenda, you will first need to install a XAMPP.

• Download XAMPP here <https://www.apachefriends.org/download.html>

• Once downloaded, run the .exe file.

• Leave everything on default, and press "Next".

• Once downloaded and file is executed, you will be brough to the XAMPP
Control Panel:

![A screenshot of a computer Description automatically
generated](./media/image1.png){width="6.5in"
height="4.232638888888889in"}

• Click "Start" on the Modules "Apache" and "MySQL"

• Once both lit green, your XAMPP is ready.

![A screenshot of a computer Description automatically
generated](./media/image2.png){width="5.833333333333333in"
height="2.3854166666666665in"}

**Setting up the database**

• To import the database, you want to go to your browser and type
localhost/phpmyadmin/

• Afterwards, you want to look for the "Import" button

• Then, you want to click on "Choose File"

![A screenshot of a computer Description automatically
generated](./media/image3.png){width="6.5in"
height="1.7993055555555555in"}

• Select the SQL file "database" and click open

![A screenshot of a computer Description automatically
generated](./media/image4.png){width="6.5in"
height="4.728472222222222in"}

• Finally, scroll down to the bottom and click on "Import". Now, you are
ready to run the Trackgenda.sln to run the project.

**Pages**

**Login Page**

The first page a user will be prompted to after running the solution.

Contains:

-   Username Field: A text field where users can enter their username
    associated with their Trackgenda account.

-   Password Field: A password field where users can securely input
    their password. The characters are masked for security.

-   \"Forgot Password? Label\": A label that users can click if they\'ve
    forgotten their password. Clicking this label redirects them to the
    password recovery/reset page.

-   \"Register Here\" Button: A button that users can click if they
    don\'t have a Trackgenda account yet. Clicking this button redirects
    them to the registration page.

-   \"Login\" Button: A button that users click to submit their login
    credentials and access their Trackgenda account.

If users enter incorrect login credentials, error messages are displayed
in a popup message to inform them of the issue.

![A screenshot of a login page Description automatically
generated](./media/image5.png){width="3.111111111111111in"
height="4.256944444444445in"}

**Registration Page**

The Registration Page contains the registration form, where new users
can sign up for a Trackgenda account.

Contains:

-   Email Address Field: A text field where users enter their email
    address. This field includes validation to ensure the entered email
    address is valid and not in use.

-   Username Field: A text field where users enter their desired
    username. This field includes validation to ensure usernames meet
    certain criteria and are not in use. (e.g., minimum 4 characters,
    and only "\_" and "." are allowed as special characters)

-   Password Field: A password field where users enter their chosen
    password. This field includes validation to ensure passwords meet
    security requirements (e.g., minimum eight characters, at least one
    uppercase letter, one lowercase letter, one number and one special
    character).

-   Confirm Password Field: A password field where users re-enter their
    chosen password to confirm accuracy. This field must match the
    password entered in the previous field.

![A screenshot of a login form Description automatically
generated](./media/image6.png){width="4.677083333333333in"
height="6.333333333333333in"}

**Forgot Password Page**

The Forgot Password Page contains the password reset form, where users
can change their password if they've forgotten it. They will require to
input their current valid username and email address. The password will
follow the same security validity check done in the Registration Form.

![A screenshot of a login form Description automatically
generated](./media/image7.png){width="4.666666666666667in"
height="5.375in"}

**Progress Bar Page**

After a user successfully inputs their username and password in the
login page, they will be prompted to the Progress Bar page. This page
has absolutely no utility and was done for fun and graphical appeal.
Once the progress reaches 100%, they will be prompted to the main App,
the Calendar Page.

![A calendar with a red and white bag Description automatically
generated](./media/image8.png){width="5.708333333333333in"
height="2.9583333333333335in"}

**Calendar Page**

![A white sheet with black lines Description automatically
generated](./media/image9.png){width="6.5in"
height="3.7423611111111112in"}

**Upper bar:**

Hamburger Menu Icon:

-   Clicking on this icon toggles the sidebar, allowing users to
    conveniently open or close it to access additional features and
    options.

Weather Display API:

-   Weather Icon: An icon representing the current weather condition
    (e.g., sun for clear skies, clouds for overcast weather, raindrops
    for rain).

-   Temperature: The current temperature is displayed in degrees Celsius
    or Fahrenheit, depending on the user\'s preference.

Clock/Time Display:

-   At the right corner of the upper bar, there\'s a label display that
    shows the current time.

**Sidebar:**

Calendar:

Weekly Calendar:

The main section of the page displays the weekly calendar view, with
each day of the week arranged horizontally and divided into time slots
vertically. Users can navigate between different weeks using the next
and previous buttons to view past or future weeks. They are also able to
switch into a monthly calendar view by clicking on the monthly button.

-   Users can input events by clicking on the desired time slot on the
    calendar.

-   Upon clicking, a modal or form appears where users can enter event
    details and choose a theme for the event background with a
    predefined color-selection in a dropdown.

-   Events are visually represented on the calendar grid, occupying the
    appropriate time cells and days.

-   Event titles may be truncated if they exceed a certain length to
    maintain readability within the time slot.

-   Users are able to edit an existing event by clicking on its label.

![A grid of lines with orange text Description automatically generated
with medium confidence](./media/image10.png){width="6.5in"
height="3.6354166666666665in"}

![A screenshot of a computer Description automatically
generated](./media/image11.png){width="4.760416666666667in"
height="4.010416666666667in"}

![A white sheet with a red box Description automatically
generated](./media/image12.png){width="6.5in"
height="3.5881944444444445in"}

Monthly Calendar:

The main section of the page displays the monthly calendar view, with
each day of the month arranged in a grid format. Users can navigate
between different months using next and previous buttons to view past or
future months.

-   Users can input events by clicking on the desired day on the
    calendar.

-   Upon clicking, a modal or form appears where users can enter event
    details.

-   Users can also select the background color for the event from a
    predefined color palette in a dropdown.

-   A maximum of three events per day are permitted to maintain
    readability and prevent overcrowding on the calendar.

-   By clicking on an existing event, a user may modify the event.

![A screenshot of a calendar Description automatically
generated](./media/image13.png){width="6.5in"
height="3.722916666666667in"}

![A screenshot of a computer Description automatically
generated](./media/image14.png){width="4.729166666666667in"
height="2.4479166666666665in"}

![A screenshot of a calendar Description automatically
generated](./media/image15.png){width="6.5in"
height="3.998611111111111in"}

TODO List:

-   The TODO Form resembles a notepad or text editor, providing users
    with a blank area where they can freely write down their tasks and
    notes.

-   Users can type, edit, and delete text as they please, with no
    predefined structure or formatting enforced.

![A screenshot of a computer Description automatically
generated](./media/image16.png){width="4.572916666666667in"
height="4.59375in"}

Study Technique:\
This Study Page provides users with the flexibility to choose and
customize their study techniques and preferences, allowing them to
optimize their study sessions and improve their productivity and focus
while using the Trackgenda application.

-   Start Button: A button that users click to start the study timer.
    Once clicked, the timer begins counting down until the end of the
    study session or break.

-   Pause Button: A button that allows users to pause the study timer if
    they need to take a break or attend to other tasks momentarily.

-   Reset Button: A button that resets the study timer back to its
    initial state, allowing users to start a new study session or break
    from the beginning.

![A group of rectangular white rectangular objects with black text
Description automatically
generated](./media/image17.png){width="4.666666666666667in"
height="1.5104166666666667in"}

![A screen shot of a computer Description automatically
generated](./media/image18.png){width="5.0in"
height="2.0729166666666665in"}

Stopwatch:

-   The Stopwatch Form displays the stopwatch interface, presenting
    users with a digital stopwatch that shows elapsed time.

-   The stopwatch display includes hours, minutes, seconds, and
    milliseconds, formatted in a clear and easily readable manner.

-   The stopwatch can be stopped after being started and reset to allow
    users to start the count from the beginning.

![A black number on a white background Description automatically
generated](./media/image19.png){width="4.302083333333333in"
height="1.65625in"}

Notes:

This Notes Form Page provides users with a convenient and user-friendly
platform for creating, managing, and navigating their notes, allowing
them to add, edit, delete, and clear notes with ease.

![A screenshot of a computer Description automatically
generated](./media/image20.png){width="5.364583333333333in"
height="7.291666666666667in"}

Motivational Quote:

This Motivational Quotes Page provides users with daily inspiration and
encouragement, delivering fresh motivational quotes fetched from an
external API.

![A screenshot of a quote Description automatically
generated](./media/image21.png){width="4.104166666666667in"
height="2.5208333333333335in"}

Fun Fact:

This Fun Fact Page provides users with a delightful daily dose of trivia
and amusement, delivering interesting fun facts about the current date.\
![A black text on a white background Description automatically
generated](./media/image22.png){width="4.114583333333333in"
height="2.3333333333333335in"}

Background Form Page:

This Background Form Page provides users with the flexibility to
personalize their calendar views and settings tab page by selecting and
applying custom background images or GIFs, enhancing the visual appeal
and user experience of the Trackgenda application.\
![A screenshot of a cell phone Description automatically
generated](./media/image23.png){width="2.1041666666666665in"
height="3.0833333333333335in"}

Settings Page:

This Settings Page provides users with the flexibility to update their
account information, customize their theme preferences, personalize
their study time settings, and choose their preferred language or
measure of temperature allowing them to tailor their Trackgenda
experience to their needs and preferences.

![A screenshot of a computer Description automatically
generated](./media/image24.png){width="6.5in"
height="3.5909722222222222in"}
