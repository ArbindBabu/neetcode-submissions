public class TimeMap {

    private Dictionary<string, SortedList<int,string>> tmp;

    public TimeMap() {
        tmp = new Dictionary<string, SortedList<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!tmp.ContainsKey(key))
        {
            tmp[key] = new SortedList<int, string>();
        }
        tmp[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if(!tmp.ContainsKey(key))
        return "";

        var timestamps = tmp[key];
        int left = 0;
        int right = timestamps.Count - 1;

        while(left <= right)
        {
            int mid = left + (right - left)/2;
            if(timestamps.Keys[mid] == timestamp)
            {
                return timestamps.Values[mid];
            }
            else if (timestamps.Keys[mid] < timestamp)
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1 ;
            }
        }
        if(right >= 0)
        {
            return timestamps.Values[right];
        }
        return "";
    }
}
