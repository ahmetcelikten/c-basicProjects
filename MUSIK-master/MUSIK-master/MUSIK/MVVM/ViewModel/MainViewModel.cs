using MUSIK.MVVM.Model;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSIK.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<Item> Songs { get; set; }
        public MainViewModel()
        {
            Songs = new ObservableCollection<Item>();
            PopulateCollection();
        }

        void PopulateCollection()
        {
            var client = new RestClient();
            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator("BQAnCKgdvHl1UbyVGQgQyqH8Q64tisCug036-cMFPxxkma73fnI0qpAiAA_XN0KCMafRZvCV9AGdRSKATHZ5Y9IijLca4jGUpycl1vM0qFWuV1aRf-yRXmuC_lxRAe0cROScL3s4RWJzQwcLaWGXFlk2ei9K_ugU7PAFsOqBtwlDDRwWuD9pT2ZtQOLIo-dS2ddTV5bztIUpg94GNuol", "Bearer");

            var request = new RestRequest("https://api.spotify.com/v1/browse/new-releases", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var response = client.GetAsync(request).GetAwaiter().GetResult();
            var data = JsonConvert.DeserializeObject<TrackModel>(response.Content);

            for (int i = 0; i < data.Albums.Limit; i++)
            {
                var track = data.Albums.Items[i];
                track.Duration = "2:32";
                Songs.Add(track);

            }
        }
    }
}
