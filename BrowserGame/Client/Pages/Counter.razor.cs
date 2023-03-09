using Microsoft.AspNetCore.Components;

namespace BrowserGame.Client.Pages
{
    public partial class Counter : ComponentBase
    {
    private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}

