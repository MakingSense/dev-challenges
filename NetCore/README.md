## .NET Core Challenges

Here are the challenges that you may choose to try out for .NET development.

### Blogging platform

**Create a minimal expression (from your perspective) of a blogging platform (BackEnd).**

At the minimum, it should be able to:

- Create posts
- List posts
- Delete posts

Some ideas on how to adapt it further follow. Feel free to add your own! They are not required but highly encouraged:

- Identify the author with some kind of authentication: only they can create posts under their name
- Allow for different states of a post:
    - Draft: only the author can see them, they do not appear in a blog
    - Private: only the author can see them, they appear in the author's blog only if the logged in user is the author
    - Public: everyone can see them
- Include a UI client that consumes this API
- Unit Tests / Integration Tests / E2E tests

### Code Review

**Perform a review of [WebApiCore-Seed](https://github.com/MakingSense/WebApiCore-Seed), review as much as you can.**

Not everything is important, but if you're in doubt, you can check our [evaluation criteria](../EvaluationCriteria.md).
