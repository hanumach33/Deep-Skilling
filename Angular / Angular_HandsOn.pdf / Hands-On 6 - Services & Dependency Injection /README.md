# Hands-On 6 - Services & Dependency Injection

## Objective

Learn how to create and use Angular services with Dependency Injection to share data between multiple components.

---

## Topics Covered

- Angular Services
- Dependency Injection
- Singleton Service
- Service-to-Service Injection
- Component-Level Providers
- Shared State

---

## Generate Files

```bash
ng generate service services/course

ng generate service services/enrollment

ng generate service services/notification
```

---

## Create Model

```text
src/app/models/course.model.ts
```

---

## Files

- models/course.model.ts
- services/course.service.ts
- services/enrollment.service.ts
- services/notification.service.ts
- pages/course-list/course-list.component.ts
- pages/home/home.component.ts
- pages/student-profile/student-profile.component.ts
- components/course-card/course-card.component.ts
