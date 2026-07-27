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

## Step 2 Create Branch

```bash
git branch GitWork
git switch GitWork
```

---

## Step 3 Create hello.xml

```bash
echo "<message>Hello from GitWork</message>" > hello.xml
```

---

## Step 4 Check Status

```bash
git status
```

---

## Step 5 Stage and Commit

```bash
git add hello.xml
git commit -m "Added hello.xml
