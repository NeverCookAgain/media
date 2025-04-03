# Never Cook Again game repository
## Acknowledgments
* [Robin Berk](https://github.com/SkullySurvivor) - Writing, 2D art, and game design
* [Jessie Chen](https://github.com/JessieQ-Q) - Creating 3D models (props) and gameplay design
* [Caroline Johnston](https://github.com/car0rj) - Programming and gameplay design
* [Christian Toney](https://github.com/Christian-Toney) - Project management, gameplay design, and programming

Everyone plays a role in the game's direction.

## Development
### Requirements
This project requires the following:
* Unity Hub
* Visual Studio Code
* Git

### Clone the repository to your local machine
Open Visual Studio Code and press CTRL+SHIFT+P (or CMD+SHIFT+P) to open the Command Palette. Type in "git clone" and select "Git: Clone". Select "Clone from GitHub". After signing in with GitHub, select `NeverCookAgain/game`. Choose a memorable place to put this repository.

### Add the project to Unity Hub
Assuming that you have Unity Hub on your machine, you can now add the project to your list by pressing the "Add" button.

![image](https://github.com/user-attachments/assets/f49ceae0-adc1-46b6-a19e-0c5d98193b9b)

Select the project folder that you cloned, and the project should appear on your list. If you don't have the correct Unity Editor version installed, Unity Hub will tell you to install it. You're now ready to **open** the project. *dramatic music*

### Authenticating in Git
While Unity takes five business years to load, let's authenticate on Git. On Visual Studio Code, open the Terminal. Set your name and email for the repository by running these two commands:

```bash
git config user.name "Your Name" # Replace with your name
```

```bash
git config user.email "example@email.com" # Replace with your GitHub email address
```

If you have a valid email connected to your GitHub account, your commits will show up as your GitHub username and your profile photo.

![{BD8AB741-F1DD-4475-9E92-7AC8EE9AAA8E}](https://github.com/user-attachments/assets/2c656af0-c740-49dc-9bd7-949daa60e8e3)

> [!NOTE]
> If the email that you set gets removed from your GitHub account, your commits will show up with the `user.name` that you set.
> 
> ![{E12A33AD-F5A3-4A6D-9C27-2E9F44072BBF}](https://github.com/user-attachments/assets/5fbc13ba-4d1a-4e92-ac51-7df48f693d8e)

### Create or checkout to a development branch
> [!WARNING]
> Avoid directly committing to the `main` branch. This could cause stability issues for the entire team.

Create a new branch for you to do your work. You can do this by using [GitHub's branch viewer](https://github.com/NeverCookAgain/game/branches), using [GitHub Issues](https://docs.github.com/en/issues/tracking-your-work-with-issues/using-issues/creating-a-branch-for-an-issue), or [local commands](https://stackoverflow.com/a/66883047). If you're not familiar with programming, GitHub Issues might be the easiest for you to use.

If you use GitHub's branch viewer or GitHub Issues, press CTRL+SHIFT+P (or CMD+SHIFT+P) to open the Command Palette. Type in "git fetch" and select "Git: Fetch". Then, open the Command Palette again. Type in "git checkout" and select "Git: Checkout". Select your branch.

Good job, you're ready to do the thing.

### Commit and push your changes regularly
If you make some progress, be sure to commit regularly. Visual Studio Code will tell you if something changed, but if you're only doing some GameObject editing and have Visual Studio Code closed, nothing except Unity will tell you that you made changes. 

> [!WARNING]
> ![](https://europe1.discourse-cdn.com/unity/original/3X/8/2/82264b0281ab08891406b4d961b2f18e8b6ebfbd.jpeg)
> 
> All hope lost for all ye who see this.

To prevent the next World War with Unity, commit your changes regularly. You can do so by using Visual Studio Code's built-in source control features.

![image](https://github.com/user-attachments/assets/e349b7de-f171-482b-9e30-b88d19120834)

Just press the branch icon, "stage" your changes by pressing the plus icon, type in a summary message, then press commit.

> [!TIP]
> For the tech-savvy people on the team, you can also use the `git commit` command.

If you try to push your changes using Visual Studio Code, it may ask you to sign in to GitHub. This is required. 

### Make a pull request to the `main` branch
Once you're ready to share, [create a pull request](https://github.com/NeverCookAgain/game/compare) from your branch to the `main` branch. If it's urgent, feel free to merge it immediately; however, under normal circumstances, leave it open and add another programmer as a reviewer.

> [!TIP]
> Since this repository is public, we also have [draft pull requests](https://github.blog/news-insights/product-news/introducing-draft-pull-requests/), so feel free to create a pull request even if it isn't ready yet. The team would love to see your progress.

## Contributions
### Feature additions, updates, and removals
TBD

### Bug fixes
TBD

### Repository management
> [!IMPORTANT]
> Every feature should be based on the gameplay design repository. If the feature isn't defined there first, do not add it to this repository yet.
