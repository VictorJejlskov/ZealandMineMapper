<template>
  <aside>
    <div class="pt-5 ">
      <!-- Logo -->
      <a href="" class="flex items-center pl-2.5 mb-5">
        <img
          v-bind:src="`./assets/imgs/Logo/OnlyFishLogo.png`"
          class="mr-3 h-6 sm:h-7"
          alt="" />
        <span
          class="self-center text-xl font-semibold whitespace-nowrap text-dark-gray"></span>
      </a>
      <ul class="space-y-2">
        <li>
          <!-- Home -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <HomeIcon />
            </div>
            <span class="ml-3">Home</span>
          </a>
        </li>
        <li>
          <!-- Notifications -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <BellIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Notifications</span>
          </a>
        </li>
        <li>
          <!-- Messages -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <ChatBubbleBottomCenterTextIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Messages</span>
          </a>
        </li>
        <li>
          <!-- Bookmarks -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <BookmarkIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Bookmarks</span>
          </a>
        </li>
        <li>
          <!-- Lists -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <ListBulletIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Lists</span>
          </a>
        </li>
        <li>
          <!-- Subscriptions -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <HeartIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Subscriptions</span>
          </a>
        </li>
        <li>
          <!-- Add card -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <CreditCardIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">Add card</span>
          </a>
        </li>
        <li>
          <!-- My profile -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <UserIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">My profile</span>
          </a>
        </li>
        <li>
          <!-- More -->
          <a
            href="#"
            class="flex items-center p-2 text-base font-normal text-dark-gray-900 rounded-lg text-dark-gray hover:bg-gray-100 dark:hover:bg-gray-700">
            <div className="h-6 w-6">
              <EllipsisHorizontalCircleIcon />
            </div>
            <span class="flex-1 ml-3 whitespace-nowrap">More</span>
          </a>
        </li>
      </ul>
    </div>
  </aside>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import {
  HomeIcon,
  BellIcon,
  ChatBubbleBottomCenterTextIcon,
  BookmarkIcon,
  ListBulletIcon,
  HeartIcon,
  CreditCardIcon,
  UserIcon,
  EllipsisHorizontalCircleIcon,
} from "@heroicons/vue/24/solid";

export default defineComponent({
  setup() {
    return {};
  },
  components: {
    HomeIcon,
    BellIcon,
    ChatBubbleBottomCenterTextIcon,
    BookmarkIcon,
    ListBulletIcon,
    HeartIcon,
    CreditCardIcon,
    UserIcon,
    EllipsisHorizontalCircleIcon,
  },
});
</script>
