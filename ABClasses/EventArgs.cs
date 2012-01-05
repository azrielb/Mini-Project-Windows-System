using System;

namespace ABClasses {
    //This class was taken from http://blogs.microsoft.co.il/blogs/shlomo/archive/2008/11/19/eventargs-lt-t-gt.aspx, with some changes. 
    //This is a good idea! (see the link).
    class EventArgs<T> : EventArgs {
        //One field
        private readonly T data;

        //One property
        public T Data {
            get { return data; }
        }

        //Constructor
        public EventArgs(T data) {
            this.data = data;
        }

    }
}