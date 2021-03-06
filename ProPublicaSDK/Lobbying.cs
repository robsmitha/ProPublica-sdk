﻿using ProPublicaSDK.Entities;
using ProPublicaSDK.Entities.Lobbying;
using ProPublicaSDK.Interfaces;
using ProPublicaSDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProPublicaSDK
{
    public class Lobbying : BaseAuthorization, ILobbying
    {
        public Lobbying(string apiKey) : base(apiKey) { }
        public List<LobbyingRepresentationModel> GetRecentLobbyingRepresentations()
        {
            var response = Send<Response<IEnumerable<LobbyingListResult>>>($"lobbying/latest.json");
            if (response?.results == null) return new List<LobbyingRepresentationModel>();

            var data = response.results.FirstOrDefault()?.lobbying_representations;
            return data != null
                ? _mapper.Map<List<LobbyingRepresentationModel>>(data)
                : new List<LobbyingRepresentationModel>();
        }
    }
}
