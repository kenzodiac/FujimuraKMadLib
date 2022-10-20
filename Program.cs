//Kenneth Fujimura
//10-20-2022
//GitHub Challenge # 5 - Mad Lib
//Console Program will guide user to complete a 'Mad Lib' story by soliciting words to fill in the blanks of the Mad Lib.
// Peer Reviewed By: Aisha Mashrah
// His work is perfect.Its good for Submission Guidelines.Its different then all the codes I have reviewed its really fun to play.The Ability to play again and the 
// Data validation both work well.

Console.Clear();

//Greet user and explain the program to them.
Console.WriteLine("Hello! This is a Mad Lib generation program. Let's create a Mad Lib together! \nI am going to ask you to provide a series of words, please input them on the keyboard when prompted.");

//while loop for repeating story generation.
bool repeatProgram = true;

//variables to hold madlib word inputs
string name1 = "";
string verb1 = "";
string sport1 = "";
string musicGenre1 = "";
string pet1 = "";
string petName1 = "";
string name2 = "";
string verb2 = "";
string hobby1 = "";
string musicGenre2 = "";

//array to hold game text instructions for the player
string[] gameText = {
    "\nPlease give me a person's name: ",
    "\nGreat. Now give me a verb. A verb is an action like 'dance' or 'run': ",
    "\nNow, write the name of an athletic sport: ",
    "\nNow give me the name of a musical genre: ",
    "\nExcellent. Now tell me the name of a type of animal: ",
    "\nOkay. Now give me a second name: ",
    "\nNow, give me the name of a third person: ",
    "\nNow give me a second verb: ",
    "\nWonderful! We're almost there. Now, give me the name of a hobby: ",
    "\nGreat. Now, give me the name of a second musical genre: "
};

//custom method for taking in player inputs to populate madlib story
string PopulateWords(string wordPass, string textPass) {
    Console.Write(textPass);
    while (wordPass == ""){
        wordPass = Console.ReadLine();
    }
    return wordPass;
}

//while loop beginning for replay purposes
while (repeatProgram == true) {
    
    //Begin soliciting words to fill in the blanks of the Mad Lib. Declare variables along the way.
    name1 = PopulateWords(name1, gameText[0]);
    
    verb1 = PopulateWords(verb1, gameText[1]);

    sport1 = PopulateWords(sport1, gameText[2]);

    musicGenre1 = PopulateWords(musicGenre1, gameText[3]);

    pet1 = PopulateWords(pet1, gameText[4]);

    petName1 = PopulateWords(petName1, gameText[5]);

    name2 = PopulateWords(name2, gameText[6]);

    verb2 = PopulateWords(verb2, gameText[7]);

    hobby1 = PopulateWords(hobby1, gameText[8]);

    musicGenre2 = PopulateWords(musicGenre2, gameText[9]);

    Console.Write("\nThank you. That's all! Here is the story you helped to write: \n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

    //Output Mad Lib story with words integrated.
    Console.WriteLine($"This is the story of {name1}. {name1} was a simple person who enjoyed simple things. They liked to {verb1}, play {sport1}, and sing {musicGenre1} in the shower. Life was good. \n\nBut then one day, {name1} met a strange person while walking their {pet1}, {petName1}. Their name was {name2}. They were a new neighbor of {name1}'s and {name1} thought them quite peculiar.\n\nBecause instead of liking to {verb1}, they liked to {verb2} instead. Instead of playing {sport1}, or really any kind of sports, {name2} was an enjoyer of {hobby1}. And instead of {musicGenre1} they liked {musicGenre2}!? \n\n{name1} could not fathom such a bizarre person. \n\nBut that's because {name1} was a person lacking in empathy and had a narrow worldview. So {name1} subconsciously avoided {name2} in order to avoid the terrible cognitive dissonance in his head. Never realizing that {name2} was secretly their long lost sibling! Gasp! How tragic.\n\nThe End.\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    //Ask user if they want to repeat the story with new words. Loop if yes. End if no.
    Console.Write("\n\nThank you for playing, I hope you enjoyed the story.\nWould you like to play again? Y/N: ");
    
    //while loop to ask user if they want to repeat; loops if given incorrect input.
    bool repeatAnswerCounter = true;
    while (repeatAnswerCounter == true) {
        string repeatAnswer = Console.ReadLine().ToLower();
        if (repeatAnswer == "y" || repeatAnswer == "yes") {
            repeatProgram = true;
            repeatAnswerCounter = false;
        } else if (repeatAnswer == "n" || repeatAnswer == "no") {
            repeatProgram = false;
            repeatAnswerCounter = false;
        } else {
            Console.Write("I do not understand that input. Please answer with Y/N: ");
            repeatAnswerCounter = true;
        }
    }
}
Console.WriteLine("\nThank you, have a nice day!");