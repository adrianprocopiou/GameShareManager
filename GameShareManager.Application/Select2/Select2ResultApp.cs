using System.Collections.Generic;

namespace GameShareManager.Application.Select2
{
    public class Select2ResultApp <TViewModel> where TViewModel : class
    {
        public int total_count;
        public List<TViewModel> result;

        public Select2ResultApp(int total_Count, List<TViewModel> result)
        {
            this.total_count = total_Count;
            this.result = result;
        }
    }
}