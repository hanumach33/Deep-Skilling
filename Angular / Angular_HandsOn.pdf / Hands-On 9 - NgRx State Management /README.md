# Hands-On 9 - NgRx State Management

## Objective

Implement NgRx Store for centralized state management in the Student Course Portal.

---

## Topics Covered

- NgRx Store
- Actions
- Reducers
- Selectors
- Effects
- Entity State
- Redux DevTools

---

## Install NgRx

```bash
ng add @ngrx/store

ng add @ngrx/effects

ng add @ngrx/store-devtools
```

---

## Folder Structure

```
src/app/store

├── actions
│      course.actions.ts
│
├── reducers
│      course.reducer.ts
│
├── selectors
│      course.selectors.ts
│
├── effects
│      course.effects.ts
│
└── state
       app.state.ts
```

---

## Files

- app.state.ts
- course.actions.ts
- course.reducer.ts
- course.selectors.ts
- course.effects.ts
- course.service.ts
- course-list.component.ts
