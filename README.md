# WordSearch-CS

#### An Epicodus Friday independent project in CSharp xUnit testing, 06.02.17

#### **By Anabel Ramirez**

## Description

This web application will allow a user to find all the instances a word appears in a given sentence.

|Behavior| Input (User Action/Selection)| Output (Program Action)|Description|
|---|---|---|---|
|Program will recognize when a word in a sentence and the search word are identical. |Sentence: "hi world", Search string: "hi"|"hi" appears once in "hi world" |The program can successfully recognize when the search word matches words in a sentence. |
|Program will recognize when a word in a sentence and the search word are not identical. |Sentence: "Hello world", Search string: "hi"|"hi" does not appear once in "hello world" |The program can successfully recognize when the search word does not match any words in a sentence.|
|Program will recognize how many times a search word appears in a sentence and is identical to the search word. | "Hi world, hi universe." |"hi" appears twice. |The program can successfully recognize when the search word and search string match more than once.|
|Program will ignore any partial matches in the sentence. | "Hi world, high universe." | "Hi" appears once in the sentence "Hi" world, hello universe." |The program can successfully recognize when the search word is not a partial match. |

## Setup/Installation Requirements

Must have current version of .Net and Mono installed

Copy all files and folders to your desktop or {git clone} the project using this link https://github.com/AnabelGR/WordSearch-CS. Navigate to the folder in your Windows power shell and run {dnx kestrel} to start the web server. Then, in your address bar, navigate to {//localhost:5004} to get to the home page.

## Known Bugs

* No known bugs


## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact the contributor through Github.

## Technologies Used

* HTML
* CSS
* Bootstrap
* JSON
* C#
* Nancy
* Razor
* xUnit

### License
This software is licensed under the MIT license.

Copyright (c) 2017 **Anabel Ramirez**
