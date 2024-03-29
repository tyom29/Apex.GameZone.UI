﻿using Apex.GameZone.UI.Models;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.GamezoneServices;

public class GamezoneService : IGamezoneService
{
    private readonly ICommonService _commonService;

    public GamezoneService(ICommonService commonService)
    {
        _commonService = commonService;
    }

    public async Task<List<GameZoneModel>> GetAllGameZones()
    {
        var requestUrl = "gamezone";
        return await _commonService.HttpRequest<string, List<GameZoneModel>>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<GameZoneModel> GetGameZoneById(int id)
    {
        var requestUrl = $"gamezone/{id}";
        return await _commonService.HttpRequest<string, GameZoneModel>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<int> CreateGameZone(GameZoneModel gameZone)
    {
        var requestUrl = "gamezone";
        return await _commonService.HttpRequest<GameZoneModel, int>(HttpMethod.Post, "", requestUrl, gameZone);
    }
    public async Task UpdateGamezone(GameZoneModel model)
    {
        var requestUrl = "gamezone";
        await _commonService.HttpRequest<GameZoneModel, string>(HttpMethod.Put, "", requestUrl, model);
    }

    public async Task DeleteGameZone(GameZoneModel model)
    {
        var requestUrl = "gamezone";
        await _commonService.HttpRequest<GameZoneModel, string>(HttpMethod.Delete, "", requestUrl, model);
    }
}