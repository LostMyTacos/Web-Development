package edu.wctc.jjsj.spring.service;

import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

@Service
public class PokemonService {

    private List<Pokemon> pokemon = new ArrayList<>(
            Arrays.asList
            (
                new Pokemon("Charmander", "Fire"),
                new Pokemon("Squirtle", "Water"),
                new Pokemon("Bulbasaur", "Grass")
            )
    );

    public List<Pokemon> getAllPokemon() {
        return pokemon;
    }

    public Pokemon getPokemon(String id) {
        return pokemon.stream()
                .filter(t -> t.getName().contains(id))
                .findFirst().get();
    }

    public void addPokemon(Pokemon p) {
        pokemon.add(p);
    }

    public void updatePokemon(Pokemon p, String id) {
        for(int i=0;i < pokemon.size() ;i++) {
            Pokemon poke = pokemon.get(i);
            if (poke.getName().equals(id)) {
                pokemon.set(i, p);
                return;
            }
        }
    }

    public void deletePokemon(String id) {
        pokemon. removeIf(p -> p.getName().equals(id));
    }
}
