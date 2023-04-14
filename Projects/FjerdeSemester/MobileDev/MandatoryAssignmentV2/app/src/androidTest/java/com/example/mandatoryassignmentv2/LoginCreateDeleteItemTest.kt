package com.example.mandatoryassignmentv2


import android.view.View
import android.view.ViewGroup
import android.view.ViewManager
import androidx.recyclerview.widget.RecyclerView
import androidx.test.espresso.Espresso
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.assertion.ViewAssertions.*
import androidx.test.espresso.contrib.RecyclerViewActions.actionOnItemAtPosition
import androidx.test.espresso.matcher.ViewMatchers
import androidx.test.espresso.matcher.ViewMatchers.*
import androidx.test.ext.junit.rules.ActivityScenarioRule
import androidx.test.ext.junit.runners.AndroidJUnit4
import androidx.test.filters.LargeTest
import com.example.mandatoryassignmentv2.models.SalesItemAdapter
import org.hamcrest.Description
import org.hamcrest.Matcher
import org.hamcrest.Matchers.allOf
import org.hamcrest.Matchers.`is`
import org.hamcrest.TypeSafeMatcher
import org.junit.Rule
import org.junit.Test
import org.junit.runner.RunWith
import kotlin.math.max

@LargeTest
@RunWith(AndroidJUnit4::class)
class LoginCreateDeleteItemTest {

    @Rule
    @JvmField
    var mActivityScenarioRule = ActivityScenarioRule(MainActivity::class.java)

    @Test
    fun loginCreateDeleteItemTest() {
        val appCompatEditText = onView(
            allOf(
                withId(R.id.edittext_login_username),
                childAtPosition(
                    childAtPosition(
                        withId(R.id.nav_host_fragment_content_main),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText.perform(replaceText("Victor@gmail.com"), closeSoftKeyboard())
        Thread.sleep(1500)

        val appCompatEditText2 = onView(
            allOf(
                withId(R.id.edittext_login_password),
                childAtPosition(
                    childAtPosition(
                        withId(R.id.nav_host_fragment_content_main),
                        0
                    ),
                    1
                ),
                isDisplayed()
            )
        )
        appCompatEditText2.perform(replaceText("123456"), closeSoftKeyboard())
        Thread.sleep(1500)
        val materialButton = onView(
            allOf(
                withId(R.id.button_login_sign_in), withText("LOGIN"),
                childAtPosition(
                    childAtPosition(
                        withClassName(`is`("android.widget.LinearLayout")),
                        2
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        materialButton.perform(click())
        Thread.sleep(1500)

        val floatingActionButton = onView(
            allOf(
                withId(R.id.fab),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        floatingActionButton.perform(click())
        Thread.sleep(1500)
        val editText = onView(
            allOf(
                childAtPosition(
                    childAtPosition(
                        withId(com.google.android.material.R.id.custom),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        editText.perform(replaceText("testitem"), closeSoftKeyboard())
        Thread.sleep(1500)
        val editText2 = onView(
            allOf(
                childAtPosition(
                    childAtPosition(
                        withId(com.google.android.material.R.id.custom),
                        0
                    ),
                    1
                ),
                isDisplayed()
            )
        )
        editText2.perform(replaceText("199"), closeSoftKeyboard())
        Thread.sleep(1500)
        val editText3 = onView(
            allOf(
                childAtPosition(
                    childAtPosition(
                        withId(com.google.android.material.R.id.custom),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        editText3.perform(replaceText("81611117"), closeSoftKeyboard())
        Thread.sleep(1500)
        val materialButton2 = onView(
            allOf(
                withId(android.R.id.button1), withText("OK"),
                childAtPosition(
                    childAtPosition(
                        withId(com.google.android.material.R.id.buttonPanel),
                        0
                    ),
                    3
                )
            )
        )
        materialButton2.perform(scrollTo(), click())
        Thread.sleep(1500)
        onView(withId(R.id.recyclerView)).perform(swipeDown())
        Thread.sleep(1500)
        val itemToDelete = onView(
            allOf(
                withId(R.id.recyclerView),
                childAtPosition(
                    withId(R.id.swiperefresh),
                    2
                )
            )
        )
        itemToDelete.perform(click())
        Thread.sleep(18000)
        val materialButton3 = onView(
            allOf(
                withId(R.id.button_delete), withText("Delete"),
                childAtPosition(
                    childAtPosition(
                        withId(R.id.nav_host_fragment_content_main),
                        0
                    ),
                    9
                ),
                isDisplayed()
            )
        )
        materialButton3.perform(click())
        Thread.sleep(1500)
        val materialButton4 = onView(
            allOf(
                withId(android.R.id.button1), withText("Confirm"),
                childAtPosition(
                    childAtPosition(
                        withId(com.google.android.material.R.id.buttonPanel),
                        0
                    ),
                    3
                )
            )
        )
        materialButton4.perform(scrollTo(), click())
        Thread.sleep(1500)
        val actionMenuItemView = onView(
            allOf(
                withId(R.id.action_logout), withText("Log Out"),
                childAtPosition(
                    childAtPosition(
                        withId(R.id.toolbar),
                        1
                    ),
                    1
                ),
                isDisplayed()
            )
        )
        Thread.sleep(1500)
        actionMenuItemView.perform(click())
    }

    private fun childAtPosition(
        parentMatcher: Matcher<View>, position: Int
    ): Matcher<View> {

        return object : TypeSafeMatcher<View>() {
            override fun describeTo(description: Description) {
                description.appendText("Child at position $position in parent ")
                parentMatcher.describeTo(description)
            }

            public override fun matchesSafely(view: View): Boolean {
                val parent = view.parent
                return parent is ViewGroup && parentMatcher.matches(parent)
                        && view == parent.getChildAt(position)
            }
        }
    }
}
