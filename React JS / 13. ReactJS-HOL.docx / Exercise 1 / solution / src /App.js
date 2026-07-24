import "./App.css";

import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

import {
    books,
    blogs,
    courses
} from "./Data";

function App() {

    const showBooks = true;
    const showBlogs = true;
    const showCourses = true;

    return (

        <div className="container">

            <div className="section">

                {showCourses && (
                    <CourseDetails
                        courses={courses}
                    />
                )}

            </div>

            <div className="section">

                {showBooks ? (
                    <BookDetails
                        books={books}
                    />
                ) : (
                    <h2>No Books</h2>
                )}

            </div>

            <div className="section">

                {showBlogs
                    ? <BlogDetails blogs={blogs}/>
                    : <h2>No Blogs</h2>}

            </div>

        </div>

    );

}

export default App;
