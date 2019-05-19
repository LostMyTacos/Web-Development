package edu.wctc.jjsj.spring.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class PokemonController {

    @Autowired
    private PokemonService pokemonService;

    @RequestMapping("/Pokemon")
    public List<Pokemon> getPokemon() {
        return pokemonService.getAllPokemon();
    }

    @RequestMapping("/Pokemon/{id}")
    public Pokemon getPokemon(@PathVariable String id) {
        return pokemonService.getPokemon(id);
    }

    @RequestMapping(method= RequestMethod.POST,
            value="/Pokemon")
    public void addPokemon(@RequestBody Pokemon p) {
        pokemonService.addPokemon(p);
    }

    @RequestMapping(method=RequestMethod.PUT, value="/Pokemon/{id}")
    public void updateTeam(@RequestBody Pokemon p, @PathVariable String id) {
        pokemonService.updatePokemon(p ,id);
    }

    @RequestMapping(method=RequestMethod.DELETE, value="/Pokemon/{id}")
    public void deletePokemon(@PathVariable String id) {
        pokemonService.deletePokemon(id);
    }
}
