# Marvel master-detail exercise

Use the Marvel API ([see troubleshooting notes below](#troubleshooting)) and create a small app that:

- Lists superheroes
- Allows the user to select one and look at details of the superhero

The listing should have:

- The superhero name
- The superhero image
- A flag indicating if this superhero appears in any comics or not
- A flag indicating if this superhero appears in any series or not
- A flag indicating if this superhero appears in any event or not
- A flag indicating if this superhero appears in any story or not

The detailed view should have:

- The superhero name
- The superhero image
- The biography of the superhero
- Any links available for the superhero (`urls`)

## Requirements

- Use React + Redux
- Setup a Git Repository of your own to upload the code

## Suggestions

Here are a few suggestions, but not requirements. Feel free to do them or not.

- Have the app done in two columns: a small one to the left with the listing and a large one on the right with the detail
- Implement deep-linking
- Prepare your app to have the API Key configurable (maybe as part of a release process?)
- Setup some tests for your app
- Document any decisions that you'd like to communicate, why you thought of taking some approach (maybe in a README.md?)
- No design/CSS is needed, but who are we to say no?

Marvel API: https://developer.marvel.com/

## Troubleshooting

We have received complaints that the Marvel API does not always work correctly. Feel free to change it by any other API of your choosing. The API should allow you to display a listing and details of a particular entity.

Here are some suggestions (in no particular order). API with access keys will be harder to develop but it allows us to see how you protect application configuration. APIs with OAuth will be even harder but it allows us to see how you interact with other applications (closer to full-stack development).

| API                                                                                        | Has access key? | Has OAuth? |
|--------------------------------------------------------------------------------------------|:---------------:|:----------:|
| [Star Wars API](https://swapi.co/)                                                         |                 |            |
| [Star Trek API](http://stapi.co/)                                                          |                 |            |
| [PokéAPI](https://pokeapi.co/docs/v2.html)                                                 |                 |            |
| [TheySaidSo Famous Quotes API](https://theysaidso.com/api/)                                |   ✓ (Optional)  |           |
| [Giphy API](https://developers.giphy.com/docs/)                                            |       ✓         |            |
| [NYTimes API](https://developer.nytimes.com/)                                              |       ✓         |            |
| [Spotify Web API](https://developer.spotify.com/documentation/web-api/)                    |       ✓         |     ✓     |
| [Twitter API](https://developer.twitter.com/en/docs.html)                                  |       ✓         |     ✓      |
| [StackExchange API](https://api.stackexchange.com/)                                        |       ✓         |     ✓      |
| [Instagram API](https://www.instagram.com/developer/)                                      |       ✓         |     ✓     |


Some more ideas available in [AnyAPI](https://any-api.com/) or in [Public APIs](https://github.com/public-apis/public-apis).

Any other feature that you want to use from the APIs is also very welcome! Make something cool!