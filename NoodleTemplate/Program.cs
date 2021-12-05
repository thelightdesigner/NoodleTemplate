using NoodleTemplate;
using System;
using System.IO;
using System.Text.Json;

// INFRASTRUCTURE FROM https://github.com/thelightdesigner/ScuffedWalls

string BaseDir = @"E:\New folder\steamapps\common\Beat Saber\Beat Saber_Data\CustomWIPLevels\The_Red_Room (2)"; //set this to the map folder directory
string InputMapFilePath = @$"{BaseDir}\h.dat"; //optional, reads from this file
string OutputMapFilePath = @$"{BaseDir}\HardStandard.dat"; //writes to this file

BeatMap _beatMap = File.Exists(InputMapFilePath) ? JsonSerializer.Deserialize<BeatMap>(File.ReadAllText(InputMapFilePath), TreeDictionaryJsonConverter.TreeDictionaryOptions) : BeatMap.Empty;

// dirty work goes here


File.WriteAllText(OutputMapFilePath, JsonSerializer.Serialize(_beatMap, TreeDictionaryJsonConverter.TreeDictionaryOptions));
