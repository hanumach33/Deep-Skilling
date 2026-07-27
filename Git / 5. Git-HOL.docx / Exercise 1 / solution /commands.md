# Exercise 1 Solution

## Step 1 Verify Master is Clean

```bash
git checkout master
git status
```

Expected Output

```
On branch master
nothing to commit, working tree clean
```

---

## Step 2 List Available Branches

### Local Branches

```bash
git branch
```

Example Output

```
* master
```

### Local and Remote Branches

```bash
git branch -a
```

Example Output

```
* master
  remotes/origin/master
```

---

## Step 3 Verify Remote Repository

```bash
git remote -v
```

Example Output

```
origin  https://github.com/<username>/GitDemo.git (fetch)
origin  https://github.com/<username>/GitDemo.git (push)
```

---

## Step 4 Pull Latest Changes from Remote

```bash
git pull origin master
```

For repositories using **main** as the default branch:

```bash
git pull origin main
```

Expected Output

```
Already up to date.
```

or

```
Updating xxxxxxx..yyyyyyy
Fast-forward
```

---

## Step 5 Verify Commit History

```bash
git log --oneline --graph --decorate
```

Example Output

```
* abc1234 (HEAD -> master, origin/master)
Resolved merge conflict
* 5de6789 Added .gitignore
* 7ab4321 Initial Commit
```

---

## Step 6 Push Local Changes to Remote Repository

```bash
git push origin master
```

For repositories using **main**:

```bash
git push origin main
```

Expected Output

```
Enumerating objects...
Counting objects...
Compressing objects...
Writing objects...
To https://github.com/<username>/GitDemo.git
```

---

## Step 7 Verify Repository Status

```bash
git status
```

Expected Output

```
On branch master
nothing to commit, working tree clean
```

---

## Step 8 Verify Remote Repository

Open the GitHub or GitLab repository in your browser.

Verify that:

- Latest commits are visible.
- Recently added files are present.
- Commit history matches the local repository.
- The default branch reflects the latest changes.

---

## Optional Verification

Compare the local branch with the remote branch:

```bash
git log --oneline --decorate --all
```

or

```bash
git branch -vv
```

These commands confirm that the local branch is synchronized with the remote repository.
