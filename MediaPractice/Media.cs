using System;
using System.Collections.Generic;

namespace MediaTypes
{
    abstract class Media
    {
        public string title;
        public int releaseDate;

        public Media (){}

        public Media (string aTitle, int aReleaseDate)
        {
            title = aTitle;
            releaseDate = aReleaseDate;
        }

        public abstract void MediaDescription();
    }
    
}