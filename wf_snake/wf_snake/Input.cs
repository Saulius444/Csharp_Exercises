using System;
using System.Collections; // for hashtable
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for keys

namespace Snake {
	internal class Input {
		// used to optimize inserted keys
		private static Hashtable keyTable = new Hashtable();

		// perform a check to see if a particular button is pressed
		public static bool KeyPressed(Keys key) {

			// returns a key back to the class
			if (keyTable[key] == null) {
				// if hashtable is empty returns false
				return false;
			}
			// if hashtable is not empty returns true
			return (bool) keyTable[key];
		}

		// detect if a keyboard button is pressed
		public static void ChangeState(Keys key, bool state) {

			keyTable[key] = state;
		}
	}
}
