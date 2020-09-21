using System;

namespace WitcherAPI.Classes
{
    public class QueryParameters
    {
        // max size for the product to showcase
        const int _maxsize = 25;
        // default size for the product
        private int _size = 10;

        public int Page { get; set; }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxsize, value);
            }
        }

        public string SortBy { get; set; } = "Id";

        private string _sortOrder = "asc";
        public string SortOrder
        {
            get
            {
                return _sortOrder;
            }
            set
            {
                if(value == "asc" || value == "desc")
                {
                    _sortOrder = value;
                }
            }
        }
    }
}
