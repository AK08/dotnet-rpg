using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();

        Character GetAllCharactersById(int id);
        
        List<Character> AddCharacter(Character newCharacter);
    }
}