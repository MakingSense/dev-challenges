## .NET Core Challenges

Here are the challenges that you may choose to try out for .NET development.

### Blogging platform

**Create a minimal expression (from your perspective) of a blogging platform.**

Only the Backend exposed as an API is required, but feel free to go beyond that if you want to.

At the minimum, it should be able to:

- Create posts
- List posts
- Delete posts

Some ideas on how to adapt it further follow. Feel free to add your own! They are not required but highly encouraged. Also, they are not in any particular order, so pick one of these, pick your own, whatever you feel adds more value:

- Unit Tests / Integration Tests / E2E tests
- Include a UI client that consumes this API
- Identify the author with some kind of authentication: only they can create posts under their name
- Allow for different states of a post:
    - Draft: only the author can see them, they do not appear in a blog
    - Private: only the author can see them, they appear in the author's blog only if the logged in user is the author
    - Public: everyone can see them
- Text search
