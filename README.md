<p>To start this project off I'd like to document some of the pre work that led to this projects creation. The first time I heard the term CRM was on August 5th when talking to a Media Management Company called Crystalline Media. I was inquiring info on what developer related technologies they use to run their business. When I found out they use a Customer Relationship Manager called Copper. They used it to distribute and track the progress of leads amongst their businesses sales staff. That sounded interesting and so I was wondering if they had any ideas for improvement. They did and that is what inspired me to build my own with this extra functionality.</p>

<p><em>August- September 5th</em> I spent roughly 8 hours looking into the Copper CRM to help determine what functionality aspects make up a commercial CRM. Once discovering their backend was made with Ruby on Rails, that let me down the rabbit hole of relational vs non relational databases. I researched documentation and videos comparing noSQL, mySQL and SQLite. I also discovered Copper's developer API and did research on how that could potentially help implement the additional functionality my friends business was looking for.<p>

<p><em>September 5th - 19th</em> I did over 4 hours of additional research. I now knew that Copper used the Ruby on Rails relational database structure in their backend software. I could have just went back to C#, a similarly relational database I have experience and confidence in. Although something bothered me about that. I currently was learning React, Firebase and noSQL, a non relational database. So I wanted to know if it would be possible to build this using such libraries and a non relational database. Mostly due to the analytics firebase could potentially provide for the CRM users. Also to build clarity on when and why to use each different type of database. While its becoming clearer this is a topic I am still doing further research on. Lastly I discovered firebase also gives the functionality to securely assign admin users which would come in handy for the functionalities I'm planning to achieve.</p>

#### Sunday, Sep 26th
* 9:00am: Researched specifically why most CRM's and ERP's use relational databases
* 10:00am: Researched SalesForce to note their customer experience and database info
* 10:20am: Looked into why Copper uses Ruby and Rails
* 10:30am: Looked into why SalesForce uses Oracle
* 10:45am: Reached an understanding that using relational databases for CRM's is an industry standard. Largely due to being an ACID compliant, very secure, highly queryable and scalable way of storing data.  
* 11:30am: Checked out a few of my previous C# projects to see what aspects I could apply to this one.
* 1:00pm: Began rereading the C# Pre-work section from the learnhowtoprogram.com course I had completed a few short months ago. In hopes to refresh myself on the language fundamentals before diving into this CRM.
* 1:00pm: skimmed the Getting Started With C# lessons
* 1:10pm: read through C# Data Types, Variables, Running Basic Console Apps, Branching and Looping sections.
* 2:30pm: tested out these concepts in the console using REPL and practiced launching a simple console app
* 3:00pm: Read and practiced C# Objects and Methods lessons
* 4:00pm: Scanned through TTD workflow with C# lessons

#### Monday, Sep 27th 
* 11:00am: Researched specifically why being ACID compliant was such an impacting factor for the CRM's currently available for business use.
* 12:00pm: Recorded Sundays research above
* 12:30pm: looked through commit history of my past C# project that used authentication, mySQL, and many to many relationships
* 2:30pm: resumed where I left off in the TTD C# lessons to find more info
* 3:00pm: Skimmed through TTD part 2 of C# lessons
* 3:30pm: Skimmed through Database Basics
* 6:00pm: Researched current CRM's made using C# and found a couple that are available to use for free but non with round robin functionality