# Hands-On 1 - Environment Setup, Project Structure & First Component

## Objective

Set up an Angular 20 project using Angular CLI, understand the generated project structure, and create the initial components for the Student Course Portal.

---

## Scenario

You are developing a Student Course Portal application. This first hands-on focuses on creating the Angular workspace, understanding every important generated file, and building the initial UI.

---

## Topics Covered

- Angular CLI
- Angular Workspace
- Angular Project Structure
- Standalone Components
- Angular Build Process
- Component Generation

---

## Prerequisites

- Node.js 20+
- npm
- Angular CLI v20
- VS Code

---

## Task 1 - Scaffold the Project

### Install Angular CLI

```bash
npm install -g @angular/cli
```

### Create Project

```bash
ng new student-course-portal --routing --style=css
```

Accept all default options.

### Navigate to Project

```bash
cd student-course-portal
```

### Run Application

```bash
ng serve
```

Open

```
http://localhost:4200
```

---

## Task 2 - Build Project

```bash
ng build
```

Verify the **dist/** folder is generated.

---

## Task 3 - Generate Components

```bash
ng generate component components/header

ng generate component pages/home

ng generate component pages/course-list

ng generate component pages/student-profile
```

---

## Expected Folder Structure

```
student-course-portal
│
├── src
│
├── app
│   ├── components
│   │      └── header
│   │
│   ├── pages
│   │      ├── home
│   │      ├── course-list
│   │      └── student-profile
│   │
│   ├── app.component.ts
│   ├── app.component.html
│   ├── app.routes.ts
│   └── app.config.ts
│
└── main.ts
```

---

## Files Included

- notes.txt
- header.component.html
- home.component.html
- app.component.html
