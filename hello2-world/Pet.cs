using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello2_world
{
    class Pet
    {
            private int health = 0;
            private int MAX_HEALTH = 5;
            private string name = "Buffy";

            public int GetHealth()
            {
            // new comment
                return health;

            }
            public string GetName()
            {
                return name;
            }
            public int GetMAX()
            {
                return MAX_HEALTH;
            }
            public void FeedPet()
            {
                if (health < MAX_HEALTH)
                    health++;
                else
                    MessageBox.Show("Health is at the maximum");
            }
            public void PlayPet()
            {
                if (health > 0)
                    health--;
                else
                    MessageBox.Show("Health is at a minimum");
            }
        
    }

}
