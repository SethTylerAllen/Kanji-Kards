using System;
using System.Collections.Generic;

namespace KanjiKardsAlphaBuild{
	
	class MainClass{

		public static void Main (string[] args){

			List<Card> currentDeck = new List<Card>();
			EditFunctions editFunctions = new EditFunctions ();

			string userInput;

			do {

				Console.Clear();
				Console.WriteLine ("Kanji Kards");
				Console.WriteLine ("1 - Create new card");
				Console.WriteLine ("2 - View cards");
				Console.WriteLine ("3 - Delete card");
				Console.WriteLine ("4 - Exit");

				userInput = Console.ReadLine ();

				if (userInput == "1")
					currentDeck.Add (editFunctions.CreateCard ());
				if (userInput == "2")
					editFunctions.ViewCards(currentDeck);

			} while(userInput != "4");

		}

	} // End of Main



	class EditFunctions{

		public Card CreateCard(){

			Card newCard = new Card();

			Console.Clear ();
			Console.WriteLine ("Input the meaning/translation of the kanji: ");
			newCard.meaning = Console.ReadLine();
			Console.WriteLine ("Input the kanji: ");
			newCard.kanji = Console.ReadLine();
			Console.WriteLine ("Input the Onyomi: ");
			newCard.onYomi = TakeListInput ();
			Console.WriteLine ("Input the Kunyomi: ");
			newCard.kunYomi = TakeListInput (); 	

			return newCard;

		}//End of CreateCard


		public void ViewCards(List<Card> deck){

			Console.Clear ();
			Console.WriteLine ("View Cards");
			Console.WriteLine ("");

			foreach (Card cardObject in deck) {

				Console.WriteLine (cardObject.kanji + " - " + cardObject.meaning);
				Console.WriteLine ("");
				Console.WriteLine ("Kunyomi: ");
				foreach (string reading in cardObject.kunYomi)
					Console.WriteLine (reading);
				Console.WriteLine ("");
				Console.WriteLine ("Onyomi: ");
				foreach (string reading in cardObject.onYomi)
					Console.WriteLine (reading);

				Console.WriteLine ("");

			}

			Console.WriteLine ("Input anything to go back to the main menu");
			Console.ReadLine ();

		} //End of ViewCards


		List<string> TakeListInput(){

			string userInput = null;
			List<string> inputList = new List<string> ();

			Console.WriteLine ("Input each: ");

			while (userInput != "0"){

				userInput = Console.ReadLine();

				if (userInput != "0")
					inputList.Add (userInput);

			}

			return inputList;

		} // End of TakeListInput

	} //End of Editing Functions



	class Card{

		public string meaning;
		public string kanji;
		public List<string> onYomi;
		public List<string> kunYomi;

		public int masteryLevel;
		public int reviewDate;

		public bool studiedKanji;
		public bool studiedOnYomi;
		public bool studiedKunYomi;

	} //End of Card Class

}